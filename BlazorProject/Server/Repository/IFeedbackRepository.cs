using BlazorProject.Shared;

namespace BlazorProject.Server.Repository
{
    public interface IFeedbackRepository
    {
        Task<List<Feedback>> GetFeedbackListAsync(int educationId);
    }
}
