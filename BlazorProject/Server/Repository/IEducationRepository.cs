using BlazorProject.Shared;

namespace BlazorProject.Server.Repository
{
    public interface IEducationRepository
    { 
        Task<Education> GetEducationById(int courseId);
    }
}
