using BlazorProject.Server.Repository;
using BlazorProject.Server.Repository.Impl;
using BlazorProject.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private readonly IEducationRepository _educationRepository;

        public EducationController(IEducationRepository educationRepository)
        {
            _educationRepository = educationRepository;
        }

        [HttpGet("one")]
        public async Task<IActionResult> GetEducation(int id)
        {
            var course = await _educationRepository.GetEducationById(id);
            return Ok(course);
        }
    }
}
