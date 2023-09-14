using BlazorProject.Server.Dto;
using BlazorProject.Shared;
using Task = System.Threading.Tasks.Task;

namespace BlazorProject.Server.Repository
{
    public interface ITaskAnswerRepository
    {
        Task AddTaskAnswerAsync(TaskAnswerDTO taskAnswer);
    }
}
