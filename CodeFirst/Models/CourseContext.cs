﻿using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models
{
    public class CourseContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseQuickUp> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./blog.db");
        }
    }
}
