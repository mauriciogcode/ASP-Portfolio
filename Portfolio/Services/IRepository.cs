using Portfolio.Models;

namespace Portfolio.Services
{

    public interface IRepository
    {
        List<ProjectDTO> GetProjects();
    }

}
