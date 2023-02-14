namespace Portfolio.Models
{
    //=============================================================================
    // SECCION MODEL Explicacion del nombre viewmodel
    //=============================================================================
    // Esta clase sirve para encapsular toda la informacion que sea necesaria para cargar la vista index.
    // Por eso es un nombre compuesto como Home por que es el controlador Index porque es la accion y View Model por que es para encapsular datos a mostrar
    //=============================================================================
    public class HomeIndexViewModel
    {
        public IEnumerable<ProjectDTO> ProjectsList { get; set; }
        //    public TestGuidViewModel TestGuid_1 { get; set; }
        //    public TestGuidViewModel TestGuid_2 { get; set; }
        //=============================================================================
    }
}