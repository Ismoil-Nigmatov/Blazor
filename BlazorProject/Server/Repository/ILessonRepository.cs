using BlazorProject.Shared;
using Task = BlazorProject.Shared.Task;

namespace BlazorProject.Server.Repository
{
    public interface ILessonRepository
    {
        Task<List<Lesson>> GetLessonsByCourseId(int courseId);
        Task<Lesson> GetLessonById(int id);
        Task<List<Lesson>> GetLessonAndTaskByCourseId(int courseId);
    }
}
