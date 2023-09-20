using BlazorProject.Server.Data;
using BlazorProject.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorProject.Server.Repository.Impl
{
    public class EducationRepository : IEducationRepository
    {
        private readonly AppDbContext _context;

        public EducationRepository(AppDbContext context) => _context = context;

        public async Task<Education> GetEducationById(int courseId)
        {
            var firstOrDefault = _context.Education.Include(e=> e.Course).FirstOrDefault(e => e.Course.Id == courseId);
            return firstOrDefault;
        }
    }
}
