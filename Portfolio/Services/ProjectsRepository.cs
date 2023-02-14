using Portfolio.Models;

namespace Portfolio.Services
{

    public class ProjectsRepository : IRepository
    {
        private int num = 0;

        public int numSum()
        {
            return num++;
        }
        public List<ProjectDTO> GetProjects()
        {
            return new List<ProjectDTO>()
            {
                new ProjectDTO
                {
                    Titulo = "Universidad Nacional San Martin",
                    Nombre = "Pagina web",
                    Descripcion = "Pagina realizada en ASP.Net Core, Jquery, Ajax",
                    LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent ut mauris vel neque tempor vehicula. Quisque congue accumsan libero, eget rutrum ante porttitor a. Curabitur sed nulla ut massa faucibus tincidunt. Nulla rhoncus facilisis risus eget mollis. Cras molestie venenatis tincidunt. Nullam ac turpis in purus fringilla laoreet. Aenean sit amet sodales arcu, eget porta purus. Integer ut facilisis ex. Integer odio eros, lacinia a nisi in, hendrerit accumsan lectus. Nullam facilisis ligula eu magna placerat egestas. Praesent vel fermentum lorem, id elementum enim. Donec fermentum dolor neque, sit amet semper ligula semper id. Nullam vel gravida neque.",
                    Link = $"/home/project/{numSum()}",
                    GithubLink = "https://github.com/mauriciogcode",
                    ImagenUrl = "../img/project_4.jpg",
                    ImagenSlider = new List<string> {"/img/project_2.jpg", "/img/project_4.jpg",},
                    UsedTecnologies = new List<string>{"ASP.NET", "Jquery", "Ajax"},


                },
                new ProjectDTO
                {
                    Titulo = "Rocketbot",
                    Nombre = "Pagina web",
                    Descripcion = "Web app realizada con Angular JS y ASP.Net Core",
                    LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent ut mauris vel neque tempor vehicula. Quisque congue accumsan libero, eget rutrum ante porttitor a. Curabitur sed nulla ut massa faucibus tincidunt. Nulla rhoncus facilisis risus eget mollis. Cras molestie venenatis tincidunt. Nullam ac turpis in purus fringilla laoreet. Aenean sit amet sodales arcu, eget porta purus. Integer ut facilisis ex. Integer odio eros, lacinia a nisi in, hendrerit accumsan lectus. Nullam facilisis ligula eu magna placerat egestas. Praesent vel fermentum lorem, id elementum enim. Donec fermentum dolor neque, sit amet semper ligula semper id. Nullam vel gravida neque.",
                    Link = $"/home/project/{numSum()}",
                    GithubLink = "https://github.com/mauriciogcode",
                    ImagenUrl = "../img/project_2.jpg",
                    ImagenSlider = new List<string> {"/img/project_2.jpg", "/img/project_4.jpg",},
                    UsedTecnologies = new List<string>{"ASP.NET", "Jquery", "Ajax"},

                },
                new ProjectDTO
                {
                    Titulo = "UTN - Curso Fullstack React",
                    Nombre = "Pagina web",
                    Descripcion = "Api Rest",
                    LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent ut mauris vel neque tempor vehicula. Quisque congue accumsan libero, eget rutrum ante porttitor a. Curabitur sed nulla ut massa faucibus tincidunt. Nulla rhoncus facilisis risus eget mollis. Cras molestie venenatis tincidunt. Nullam ac turpis in purus fringilla laoreet. Aenean sit amet sodales arcu, eget porta purus. Integer ut facilisis ex. Integer odio eros, lacinia a nisi in, hendrerit accumsan lectus. Nullam facilisis ligula eu magna placerat egestas. Praesent vel fermentum lorem, id elementum enim. Donec fermentum dolor neque, sit amet semper ligula semper id. Nullam vel gravida neque.",
                    Link = $"/home/project/{numSum()}",
                    GithubLink = "https://github.com/mauriciogcode",
                    ImagenUrl = "../img/project_3.jpg",
                    ImagenSlider = new List<string> {"/img/project_2.jpg", "/img/project_4.jpg",},
                    UsedTecnologies = new List<string>{"ASP.NET", "Jquery", "Ajax"},

                }
            };
        }


    }
    //=============================================================================

}
