using BlazorProject.Server.Data;
using BlazorProject.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorProject.Server.Repository.Impl
{
    public class LessonRepository : ILessonRepository
    {
        private readonly AppDbContext _context ;

        public LessonRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Lesson>> GetLessonsByCourseId(int courseId)
        {
            return await _context.Lesson.Include(l => l.Course).Where(l=> l.Course.Id == courseId).ToListAsync();
        }


        public async Task<Lesson> GetLessonById(int id)
        {
            return _context.Lesson.FirstOrDefault(l => l.Id == id);
        }
    }
}
