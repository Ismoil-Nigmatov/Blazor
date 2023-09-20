using BlazorProject.Server.Data;
using BlazorProject.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorProject.Server.Repository.Impl
{
    public class ResultRepository : IResultRepository
    {
        private readonly AppDbContext _context;
        public ResultRepository(AppDbContext context) => _context = context;
        public async Task<List<Result>> GetResultListAsync(int educationId) => await _context.Result.Include(e => e.Education).Include(u => u.User).Where(f => f.Education.Id == educationId).ToListAsync();
    }
}
