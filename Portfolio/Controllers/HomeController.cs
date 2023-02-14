using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portfolio.Models;
using Portfolio.Services;
using System.Diagnostics;

namespace Portfolio.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository _projectsRepository;

        private readonly IConfiguration _configuration;
        //private readonly ServiceScope _paramServiceScope;
        //private readonly ServiceTransient _paramServiceTransient;
        //private readonly ServiceUnico _paramServiceUnico;
        //private readonly ServiceScope _paramServiceScope2;
        //private readonly ServiceTransient _paramServiceTransient2;
        //private readonly ServiceUnico _paramServiceUnico2;


        public HomeController(ILogger<HomeController> logger,
            IRepository paramProjectsRepository
            , IConfiguration paramconfiguration
            //ServiceScope paramServiceScope,
            //ServiceTransient paramServiceTransient,
            //ServiceUnico paramServiceUnico,


            // ServiceScope paramServiceScope2,
            //ServiceTransient paramServiceTransient2,
            // ServiceUnico paramServiceUnico2
            )
        {
            _logger = logger; //servicio preconfigurado de logs
            this._projectsRepository = paramProjectsRepository;
            _configuration = paramconfiguration;
            //_paramServiceScope = paramServiceScope;
            //_paramServiceTransient = paramServiceTransient;
            //_paramServiceUnico = paramServiceUnico;
            //_paramServiceScope2 = paramServiceScope2;
            //_paramServiceTransient2 = paramServiceTransient2;
            //_paramServiceUnico2 = paramServiceUnico2;
        }




        public IActionResult Index()
        {
            var persona = new Person()
            {

                Name = "Mauricio Gonzalez"
            };



            // ViewBag.Nombre = "Gonzalez"; Dinamico pero no fuertemente tipado
            //return View("Index", "Gonzalez Mauricio"); // asi se pasa el tipado fuerte

            //var oProjectRepository = new ProjectsRepository();

            var ShorProjectList = _projectsRepository.GetProjects().Take(3).ToList();

            //=============================================================================
            // SECCION SERVICIOS Ejemplos de Servicios
            //=============================================================================


            //var objTestGuidViewModel = new TestGuidViewModel()
            //{
            //    Delimitado = _paramServiceScope.ObtainGuid,
            //    Transitorio = _paramServiceTransient.ObtainGuid,
            //    Unico = _paramServiceUnico.ObtainGuid,


            //};

            //var objTestGuidViewModel2 = new TestGuidViewModel()
            //{
            //    Delimitado = _paramServiceScope2.ObtainGuid,
            //    Transitorio = _paramServiceTransient2.ObtainGuid,
            //    Unico = _paramServiceUnico2.ObtainGuid,


            //};
            //=============================================================================
            // SECCION LOGGER Ejemplos
            //=============================================================================

            //_logger.LogTrace("Este es un trace");
            //_logger.LogDebug("Este es un Debug");
            //_logger.LogInformation("Este es un Information");
            //_logger.LogWarning("Este es un Warning");
            //_logger.LogError("Este es un Error");
            //_logger.LogCritical("Este es un Critical");

            //=============================================================================
            // SECCION LOGGER Ejemplos de Provedor de Configuracion
            //=============================================================================

            var apellido = _configuration.GetValue<string>("Apellido");
            _logger.LogInformation("Este es un apellido " + apellido);



            var ShowShortProjectList = new HomeIndexViewModel() { ProjectsList = ShorProjectList, /*TestGuid_1 = objTestGuidViewModel, TestGuid_2 = objTestGuidViewModel2*/ }; //

            //=============================================================================


            return View(ShowShortProjectList); // asi se pasa la clase al no ser un string puedo omitir el index
        }



        public IActionResult Projects()
        {
            var projectList = _projectsRepository.GetProjects();

            return View(projectList);
        }


        public IActionResult Project(int id)
        {
            if (id >= _projectsRepository.GetProjects().Count())
            {
                return Error();
            }
            var projectList = _projectsRepository.GetProjects();
            var ProjectDTO = projectList[id];
            return View(ProjectDTO);
        }

        public IActionResult Contact()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Contact(ContactViewModel contact)
        {
            return RedirectToAction("Gracias");

        }
        public IActionResult Gracias()
        {
            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}