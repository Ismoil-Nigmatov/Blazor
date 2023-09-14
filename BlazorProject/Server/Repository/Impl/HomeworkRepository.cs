using BlazorProject.Server.Data;
using BlazorProject.Shared;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;

namespace BlazorProject.Server.Repository.Impl
{
    public class HomeworkRepository : IHomeworkRepository
    {
        private readonly AppDbContext _context;

        public HomeworkRepository(AppDbContext context) => _context = context;


        public async Task<List<Homework>> GetAllHomeworkAsync()
        {
            return await _context.Homework.Include(h => h.Task).ToListAsync();
        }

        public async Task<Homework> GetHomeworkByIdAsync(int id)
        {
           return (await _context.Homework.Include(h => h.Task).FirstOrDefaultAsync(h => h.Id == id))!;
        }

        
    }
}
