using BlazorProject.Shared;

namespace BlazorProject.Server.Repository
{
    public interface ILessonRepository
    {
        Task<List<Lesson>> GetLessonsByCourseId(int courseId);
    }
}
