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
                new Course() { Id = 2, CourseId = "Python", CourseName = "Basic Python", level = Level.Basic, Fee = 6000, TrainingTime = 6 },
                new Course() { Id = 3, CourseId = "SQL", CourseName = " Basic SQL", level = Level.Basic, Fee = 6000, TrainingTime = 6},
                new Course() { Id = 4, CourseId = "JavaScript", CourseName = "Basic JavaScript", level = Level.Basic, Fee = 6000, TrainingTime = 6 },
                new Course() { Id = 5, CourseId = "Security", CourseName = "Basic Network Security", level = Level.Basic, Fee = 6000, TrainingTime = 6 });
            modelBuilder.Entity<Student>().HasData(
                new Student() { Id = 1, RollNumber = "21304", FirstName = "Ha", LastName = "Van Vu", Address = "Gia Lai", Gmail = "havanvu18@gmail.com", IdentityCard = "001201303446", StudentStatus = StudentStatus.Active , PhoneNumber = "0825894329", Dob = new DateTime(2020,02,13) , SubFee = 1000 },
                new Student() { Id = 2, RollNumber = "21404", FirstName = "Pham", LastName = "Tung Lam", Address = "Lao Cai", Gmail = "phamlamlc14@gmail.com", IdentityCard = "002302446301", StudentStatus = StudentStatus.Active , PhoneNumber = "0328658580", Dob = new DateTime(2020,03,14) , SubFee = 1000 },
                new Student() { Id = 3, RollNumber = "21504", FirstName = "Nong", LastName = "Manh Hung", Address = "Cao Bang", Gmail = "nongphanmanhhung93@gmail.com", IdentityCard = "0002304664303", StudentStatus = StudentStatus.Active, PhoneNumber = "0654871956", Dob = new DateTime(2020,04,15)  , SubFee = 1000},
                new Student() { Id = 4, RollNumber = "21604", FirstName = "Nguyen", LastName = "Trung Anh", Address = "Ha Noi", Gmail = "nguyentrunganh@gmail.com", IdentityCard = "002404356766", StudentStatus = StudentStatus.Active, PhoneNumber = "0546871264", Dob = new DateTime(2020,05,15)  , SubFee = 1000 },
                new Student() { Id = 5, RollNumber = "21704", FirstName = "Do", LastName = "Huu Cong", Address = "Ha Noi", Gmail = "huucong473@gmail.com", IdentityCard = "001201072112", StudentStatus = StudentStatus.Active, PhoneNumber = "0889567661", Dob =new DateTime(2020,06,15)  , SubFee = 1000 });
            modelBuilder.Entity<ClassStudy>().HasData(
                new ClassStudy() { Id = 1, ClassId = "CT207", Name = "Basic Java" },
                new ClassStudy() { Id = 2, ClassId = "CT208", Name = "Basic Python" },
                new ClassStudy() { Id = 3, ClassId = "CT209", Name = "Basic SQL" },
                new ClassStudy() { Id = 4, ClassId = "CT210", Name = "Basic JavaScript " },
                new ClassStudy() { Id = 5, ClassId = "CT211", Name = "Bacic Network Security" });
        }
    }
}