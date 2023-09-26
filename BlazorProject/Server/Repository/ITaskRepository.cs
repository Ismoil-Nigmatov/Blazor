namespace BlazorProject.Server.Repository
{
    public interface ITaskRepository
    {
        Task<List<Shared.Task>> GetAllTaskAsync();
        Task<List<Shared.Task>> GetTaskByLessonId(int id);
        Task<Shared.Task> GetTaskByIdAsync(int id);
    }
}
