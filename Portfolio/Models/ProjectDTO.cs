namespace Portfolio.Models
{
    public class ProjectDTO
    {
        //=============================================================================
        // SECCION MODEL  Data Transfer Obj, significa que es quien transfiere la data de un proyecto
        //=============================================================================

        public string? Titulo { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? LongDescription { get; set; }
        public string? ImagenUrl { get; set; }
        public List<String>? UsedTecnologies { get; set; }
        public string? Link { get; set; }
        public string? GithubLink { get; set; }
        public List<String>? ImagenSlider { get; set; }

        //=============================================================================

    }
}
