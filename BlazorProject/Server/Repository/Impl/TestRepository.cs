using BlazorProject.Server.Data;
using BlazorProject.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorProject.Server.Repository.Impl
{
	public class TestRepository : ITestRepository
	{
		private readonly AppDbContext _context;
		public TestRepository(AppDbContext context) => _context = context;

		public async Task<List<Test>> GetTestListAsync(int lessonId) => await _context.Test.Include(e => e.Lesson).Where(f => f.Lesson.Id == lessonId).ToListAsync();

	}
}
