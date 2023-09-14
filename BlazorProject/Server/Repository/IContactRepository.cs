using BlazorProject.Shared;
using Task = System.Threading.Tasks.Task;

namespace BlazorProject.Server.Repository
{
    public interface IContactRepository
    {
        Task AddTaskAnswerAsync(Contact contact);
    }
}
