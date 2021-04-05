using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SymphonyWebApp.Data.Configurations;
using SymphonyWebApp.Data.Entities;
using SymphonyWebApp.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SymphonyWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new ClassStudyConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new RegistrationTestConfiguration());
            modelBuilder.ApplyConfiguration(new CentreConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new ResultTestConfiguration());
            modelBuilder.ApplyConfiguration(new ExaminationConfiguration());

            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ResultTest> ResultTests { get; set; }
        public DbSet<Centre> Centres { get; set; }
        public DbSet<ClassStudy> ClassStudies { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<RegistrationTest> RegistrationTests { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Examination> Examinations { get; set; }
    }
}