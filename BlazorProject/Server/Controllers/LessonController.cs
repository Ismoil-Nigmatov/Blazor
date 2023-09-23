using BlazorProject.Server.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BlazorProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly ILessonRepository _lessonRepository;

        public LessonController(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        [HttpGet("one")]
        public async Task<IActionResult> GetOne(int id)
        {
            var lessons = await _lessonRepository.GetLessonsByCourseId(id);
            return Ok(lessons);
        }
    }
}
