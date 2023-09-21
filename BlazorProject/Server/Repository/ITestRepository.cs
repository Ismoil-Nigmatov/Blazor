using BlazorProject.Shared;

namespace BlazorProject.Server.Repository
{
    public interface ITestRepository
    {
		Task<List<Test>> GetTestListAsync(int lessonId);
	}
}
