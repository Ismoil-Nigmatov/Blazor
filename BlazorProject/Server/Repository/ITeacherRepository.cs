using BlazorProject.Shared;

namespace BlazorProject.Server.Repository
{
    public interface ITeacherRepository
    {
        Task<List<Teacher>> GetAllTeacherAsync();
        Task<Teacher> GetTeacherByIdAsync(int id);
        Task AddTeacherAsync(Teacher teacher);
        Task UpdateTeacherAsync(Teacher teacher);
        Task DeleteTeacherAsync(int id);
    }
}
