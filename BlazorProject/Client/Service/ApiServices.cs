using System.Net.Http.Json;
using BlazorProject.Client.Dto;
using BlazorProject.Client.Pages;
using BlazorProject.Server.Dto;
using BlazorProject.Shared;
using static System.Net.WebRequestMethods;
using Contact = BlazorProject.Shared.Contact;
using Task = System.Threading.Tasks.Task;
using Test = BlazorProject.Shared.Test;

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

    public async Task<Education> GetEducation(string courseId)
    {
        var result = await _httpClient.GetFromJsonAsync<Education>("/api/Education/one?id=" + courseId);
        return result;
    }

    public async Task<Course> GetCourse(string courseId)
    {
        var result = await _httpClient.GetFromJsonAsync<Course>("/api/Course/one?id=" + courseId);
        return result;
    }

    public async Task<List<Feedback>> GetFeedback(string educationId)
    {
        var result = await _httpClient.GetFromJsonAsync<List<Feedback>>("/api/Feedback/one?id=" + educationId);
        return result;
    }

    public async Task<List<Result>> GetResults(string educationId)
    {
        var result = await _httpClient.GetFromJsonAsync<List<Result>>("/api/Result/one?id=" + educationId);
        return result;
    }

    public async Task<List<Test>> GetTest(string lessonId)
    {
	    var result = await _httpClient.GetFromJsonAsync<List<Test>>("/api/Test/one?id=" + lessonId);
	    return result;
    }

	public async Task AddCourse(UserCourseDTO userCourseDto)
    {
        await _httpClient.PostAsJsonAsync("/api/User/course", userCourseDto);
    }


    public async Task<List<BlazorProject.Shared.Lesson>> GetLessons(string courseId)
    {
        var result = await _httpClient.GetFromJsonAsync<List<BlazorProject.Shared.Lesson>>("/api/Lesson/one?id=" + courseId);
        return result;
    }
}