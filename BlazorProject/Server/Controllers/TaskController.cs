using BlazorProject.Server.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;

        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }


        [HttpGet("one")]
        public async Task<IActionResult> GetOne(int id)
        {
            var task = await _taskRepository.GetTaskByIdAsync(id);
            return Ok(task);
        }
    }
}
