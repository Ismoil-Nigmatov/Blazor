using System.Net.Http.Json;
using BlazorProject.Client.Dto;
using BlazorProject.Client.Pages;
using BlazorProject.Server.Dto;
using BlazorProject.Shared;
using static System.Net.WebRequestMethods;
using Contact = BlazorProject.Shared.Contact;

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

    public async Task<List<BlazorProject.Shared.Homework>> GetHomeworkList()
    {
        var result = await _httpClient.GetFromJsonAsync<List<BlazorProject.Shared.Homework>>("api/Homework");
        return result;
    }

    public async Task<List<Teacher>> GetTeacherList()
    {
        var result = await _httpClient.GetFromJsonAsync<List<Teacher>>("api/Teacher");
        return result;
    }


    public async Task<HttpResponseMessage> Login(LoginDTO loginDto)
    {
        var response = await _httpClient.PostAsJsonAsync("/api/User/login", loginDto);
        return response;
    }

    public async Task<HttpResponseMessage> Register(UserDTO userDto)
    {
        var response = await _httpClient.PostAsJsonAsync("/api/User", userDto);
        return response;
    }

    public async void AddContact(Contact contact)
    {
        await _httpClient.PostAsJsonAsync("api/Contact", contact);
    }

    public async void AddAnswer(TaskAnswerDTO taskAnswerDto)
    {
        await _httpClient.PostAsJsonAsync("/api/TaskAnswer", taskAnswerDto);
    }
}