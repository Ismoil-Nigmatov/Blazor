using BlazorProject.Shared;

namespace BlazorProject.Server.Repository
{
    public interface IResultRepository
    {
        Task<List<Result>> GetResultListAsync(int educationId);
    }
}
