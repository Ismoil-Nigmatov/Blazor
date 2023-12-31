﻿using BlazorProject.Server.Dto;
using BlazorProject.Shared;
using Task = System.Threading.Tasks.Task;

namespace BlazorProject.Server.Repository;

public interface IUserRepository
{
    Task<List<User>> GetAllUsersAsync();
    Task<User> GetUserByIdAsync(string email);
    Task<User> AddUserAsync(UserDTO userDto);
    Task UpdateUserAsync(User user);
    Task DeleteUserAsync(int id);
    Task<List<Course>> GetUserCourses(string email);
    Task<User> Login(LoginDTO loginDto);

    Task AddCourse(UserCourseDTO userCourseDto);
}