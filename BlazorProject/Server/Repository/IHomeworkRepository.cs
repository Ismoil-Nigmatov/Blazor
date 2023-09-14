using BlazorProject.Shared;
using Task = System.Threading.Tasks.Task;

namespace BlazorProject.Server.Repository
{
    public interface IHomeworkRepository
    {
        Task<List<Homework>> GetAllHomeworkAsync();
        Task<Homework> GetHomeworkByIdAsync(int id);
    }
}
