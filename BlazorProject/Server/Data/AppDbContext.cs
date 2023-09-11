﻿using Microsoft.EntityFrameworkCore;
using BlazorProject.Shared;

namespace BlazorProject.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Course> Course { get; set; }
    }
}
