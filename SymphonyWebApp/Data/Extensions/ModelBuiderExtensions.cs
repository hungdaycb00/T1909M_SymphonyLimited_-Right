using Microsoft.EntityFrameworkCore;
using SymphonyWebApp.Data.Entities;
using SymphonyWebApp.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Extensions
{
    public static class ModelBuiderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course() { Id = 1, CourseId = "Java", CourseName = "Basic Java", level = Level.Basic, Fee = 6000, TrainingTime = 6 },
                new Course() { Id = 2, CourseId = "Python", CourseName = "Basic Python", level = Level.Basic, Fee = 6000, TrainingTime = 6 });
        }
    }
}