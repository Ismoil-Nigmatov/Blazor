using System.Net.Http.Json;
using BlazorProject.Shared;

namespace BlazorProject.Client.Service;

public class ApiServices
{
    public HttpClient _httpClient;

    public ApiServices(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Course>> GetCourseList()
    {
        var result = await _httpClient.GetFromJsonAsync<List<Course>>("api/Course");
        return result;
    }

    public async Task<List<Course>?> GetUserCourses(string email)
    {
        var result = await _httpClient.GetFromJsonAsync<List<Course>>("/api/User/course?email=" + email);
        return result;
    }

    public async Task<BlazorProject.Shared.Task> GetTask(string taskId)
    {
        var result = await _httpClient.GetFromJsonAsync<BlazorProject.Shared.Task>("/api/Task/one?id=" + taskId);
        return result;
    }

    public async Task<List<Homework>> GetHomeworkList()
    {
        var result = await _httpClient.GetFromJsonAsync<List<BlazorProject.Shared.Homework>>("api/Homework");
        return result;
    }

    public async Task<List<Teacher>> GetTeacherList()
    {
        var result = await _httpClient.GetFromJsonAsync<List<Teacher>>("api/Teacher");
        return result;
    }
}