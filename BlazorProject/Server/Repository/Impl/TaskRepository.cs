using BlazorProject.Server.Data;
using Microsoft.EntityFrameworkCore;
using Task = BlazorProject.Shared.Task;

namespace BlazorProject.Server.Repository.Impl
{
    public class TaskRepository:ITaskRepository
    {
        private readonly AppDbContext _context;

        public TaskRepository(AppDbContext context) => _context = context;

        public async Task<List<Shared.Task>> GetAllTaskAsync()
        {
            return await _context.Task.ToListAsync();
        }

        public async Task<List<Task>> GetTaskByLessonId(int id)
        {
            return await _context.Task.Include(t => t.Lesson).Where(t => t.Lesson.Id == id).ToListAsync();
        }

        public async Task<Shared.Task> GetTaskByIdAsync(int id)
        {
            return await _context.Task.FirstOrDefaultAsync(t => t.Id == id);
        }
    }
}
