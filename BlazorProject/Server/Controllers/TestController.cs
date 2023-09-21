using BlazorProject.Server.Repository;
using BlazorProject.Server.Repository.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorProject.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestController : ControllerBase
	{
		private readonly ITestRepository _testRepository;

		public TestController(ITestRepository testRepository) => _testRepository = testRepository;

		[HttpGet("one")]
		public async Task<IActionResult> GetTest(int id) => Ok(await _testRepository.GetTestListAsync(id));

	}
}
