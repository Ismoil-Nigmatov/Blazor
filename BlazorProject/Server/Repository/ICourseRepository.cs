using BlazorProject.Shared;

namespace BlazorProject.Server.Repository
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetAll();
        Task<Course> Get(int id);
        Task Add(Course course);
        Task Update(Course course);
        Task Delete(int id);
    }
}
