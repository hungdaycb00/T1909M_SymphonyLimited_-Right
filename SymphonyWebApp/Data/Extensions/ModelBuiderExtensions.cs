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
                    new Course() { Id = 3, CourseId = "SQL", CourseName = " Basic SQL", level = Level.Basic, Fee = 4275, TrainingTime = 4 },
                    new Course() { Id = 4, CourseId = "JavaScript", CourseName = "Basic JavaScript", level = Level.Basic, Fee = 6000, TrainingTime = 6 },
                    new Course() { Id = 5, CourseId = "Security", CourseName = "Basic Network Security", level = Level.Basic, Fee = 4275, TrainingTime = 4 });
          
            modelBuilder.Entity<Student>().HasData(
                new Student() { Id = 1, RollNumber = "21304", FirstName = "Ha", LastName = "Van Vu", Address = "Gia Lai", Gmail = "havanvu18@gmail.com", IdentityCard = "001201303446", StudentStatus = StudentStatus.Active, PhoneNumber = "0825894329", Dob = new DateTime(2020, 02, 13), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 2, RollNumber = "21404", FirstName = "Pham", LastName = "Tung Lam", Address = "Lao Cai", Gmail = "phamlamlc14@gmail.com", IdentityCard = "002302446301", StudentStatus = StudentStatus.Active, PhoneNumber = "0328658580", Dob = new DateTime(2020, 03, 14), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 3, RollNumber = "21504", FirstName = "Nong", LastName = "Manh Hung", Address = "Cao Bang", Gmail = "nongphanmanhhung93@gmail.com", IdentityCard = "0002304664303", StudentStatus = StudentStatus.Active, PhoneNumber = "0654871956", Dob = new DateTime(2020, 04, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 3, CourseId = 3 },
                new Student() { Id = 4, RollNumber = "21604", FirstName = "Nguyen", LastName = "Trung Anh", Address = "Ha Noi", Gmail = "nguyentrunganh@gmail.com", IdentityCard = "002404356766", StudentStatus = StudentStatus.Active, PhoneNumber = "0546871264", Dob = new DateTime(2020, 05, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 4, CourseId = 4 },
                new Student() { Id = 5, RollNumber = "21704", FirstName = "Do", LastName = "Huu Cong", Address = "Ha Noi", Gmail = "huucong473@gmail.com", IdentityCard = "001201072112", StudentStatus = StudentStatus.Active, PhoneNumber = "0889567661", Dob = new DateTime(2020, 06, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 5, CourseId = 5 });
          
            modelBuilder.Entity<ClassStudy>().HasData(
                new ClassStudy() { Id = 1, ClassId = "CT207", Name = "Basic Java"},
                new ClassStudy() { Id = 2, ClassId = "CT208", Name = "Basic Python" },
                new ClassStudy() { Id = 3, ClassId = "CT209", Name = "Basic SQL" },
                new ClassStudy() { Id = 4, ClassId = "CT210", Name = "Basic JavaScript " },
                new ClassStudy() { Id = 5, ClassId = "CT211", Name = "Bacic Network Security" });
          
            modelBuilder.Entity<Centre>().HasData(
                new Centre() { Id = 1, Address = "Phu Xuyen-Ha Noi" },
                new Centre() { Id = 2, Address = "5 Nguyen Van Loc- Ha Dong- Ha Noi" },
                new Centre() { Id = 3, Address = "56-Van Phu-Ha Dong" },
                new Centre() { Id = 4, Address = "119 Thanh Xuan-Ha Dong " },
                new Centre() { Id = 5, Address = "5 Pham Hung- My Dinh-Ha Noi" });
          
            modelBuilder.Entity<Question>().HasData(
                new Question() { Id = 1, Title = "How to join the course?", Answer = "On this the admin should be able to enter or update the procedures for joining the course that the institute offers" },
                new Question() { Id = 2, Title = "Why to join the institute? ", Answer = "The various benefits that the student can gain by joining the institution is to be provided" },
                new Question() { Id = 3, Title = "When will be Entrance Examinations Conducted? ", Answer = "Once in 6 months, and one need to check the website for knowing when is the entrance exam entitled, the fees for the entrance exam (admin will decide and displayed on the application form)" },
                new Question() { Id = 4, Title = "Can I use the Lab facilities after my class hours? ", Answer = "Will there be any extra hidden charges? (Ans: Yes, you can use the lab sessions even after your class hours. There will be no charges during the course days (i.e., during the course period if you want to use the lab sessions after the class hours we do provide the lab session and the labs will be kept opened till 9 PM in the evening. But yes if you want to use the lab session after your course completion, then it will be charged based on the scenario (like 1000$ if opted at the time of registering and 1500$ if opted after the completion of the course)" },
                new Question() { Id = 5, Title = "How can I apply for the entrance exam? ", Answer = "Ans: once the entrance exams are entitled, one need to visit the centre for applying it through paper and fill all the necessary details through online. On the application form one should chose which course he/she wanted to pursue." },
                new Question() { Id = 6, Title = "Will there be any fees for the entrance exam? ", Answer = "Ans: Yes there will be and it will be available on the application form" },
                new Question() { Id = 7, Title = "How to make the payment? ", Answer = "Ans: payment can be done through draft, or through cheque or through cash. For making the payment through cash, one needs to come to one of the centre of the institute, and make the payment there itself. Once the payment is done (through cash or through DD), the student will be provided with the receipt with a receipt number. This receipt number is to be inputted in the application form. For the payments done through cheque and DD, one need to enter the DD number and the cheque number, bank details, etc. are to be entered on the application form and the cheque is to be pinned to the application form. Only once the payment is received the student’s application will be accepted. Once the application is accepted, the student is mailed with the acknowledgement form along with the details of the examination, subject chosen, date and time of exam, and the roll number" });
            
            modelBuilder.Entity<Customer>().HasData(
                new Customer() { Id = 1, Name = "Tran Thi Tuyet", Gmail = "tuyettranlc4@gmail.com", PhoneNumber = "0395761476", Contents = "What is the school's facilities and teaching quality like?" },
                new Customer() { Id = 2, Name = "Nguyen Van Ngoc", Gmail = "ngocdra@gmail.com", PhoneNumber = "0956137845", Contents = "What will I get during my studies? " },
                new Customer() { Id = 3, Name = "Nguyen Hoai Nam", Gmail = "namot@gmail.com", PhoneNumber = "0986176340", Contents = "Can I take other experiential sessions outside the main school hours?" },
                new Customer() { Id = 4, Name = "Pham Tuyet Mai", Gmail = "maioklc@gmail.com", PhoneNumber = "0296753186", Contents = "Can I make a reservation if I miss a midterm?" },
                new Customer() { Id = 5, Name = "Le Quang Tho", Gmail = "thobeo8@gmail.com", PhoneNumber = "0364781029", Contents = "Can I leave the course for the next semester too?" });
           
            modelBuilder.Entity<RegistrationTest>().HasData(
                new RegistrationTest() { Id = 1, CourseName = "Basic Java", RegistrationFee = 100, CustomerId = 1 },
                new RegistrationTest() { Id = 2, CourseName = "Basic Python", RegistrationFee = 100, CustomerId = 2 },
                new RegistrationTest() { Id = 3, CourseName = "Basic SQL", RegistrationFee = 100, CustomerId = 3 },
                new RegistrationTest() { Id = 4, CourseName = "Basic JavaScript", RegistrationFee = 100, CustomerId = 4 },
                new RegistrationTest() { Id = 5, CourseName = "Basic Network Security", RegistrationFee = 100, CustomerId = 5 });
        }
    }
}
