using Microsoft.AspNetCore.Identity;
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
                    new Course()
                    {
                        Id = 1,
                        CourseId = "Java",
                        CourseName = "Basic Java",
                        level = Level.Basic,
                        Fee = 6000,
                        TrainingTime = 6,
                        UrlImage = "java.jpg",
                        Description = "How to write Java Programs from scratch and have loads of fun in the process" +
                    "Gain enough experience to pass a core Java Programming interview and perform well on the job,Go from zero to hero in writing industry ready Java programs"
                    },
                    new Course()
                    {
                        Id = 6,
                        CourseId = "Java",
                        CourseName = "Advance Java",
                        level = Level.Advance,
                        Fee = 4275,
                        TrainingTime = 4,
                        UrlImage = "javaAd.jpg",
                        Description = "How to navigate and use the NetBeans IDE to create Java projects, packages and programs." +
                    "How to declare and use Java Datatypes & Identifiers, work with Java Operators,  work with Java Decision Making Constructs.How to work with Java repetition/Looping Constructs, declare and use Java Arrays, as well as work with the Java Exception Handling mechanism."
                    },
                    new Course()
                    {
                        Id = 2,
                        CourseId = "Python",
                        CourseName = "Basic Python",
                        level = Level.Basic,
                        Fee = 6000,
                        TrainingTime = 6,
                        UrlImage = "python.jpg",
                        Description = "Install Python and write your first program." +
                    "Describe the basics of the Python programming language." +
                    "Use variables to store, retrieve and calculate information." +
                    "Utilize core programming tools such as functions and loops"
                    },
                    new Course()
                    {
                        Id = 7,
                        CourseId = "Python",
                        CourseName = "Advance Python",
                        level = Level.Advance,
                        Fee = 4275,
                        TrainingTime = 4,
                        UrlImage = "pythonAd.jpg",
                        Description = "How gradient descent and stochastic gradient descent algorithms work." +
                    "How to apply gradient descent and stochastic gradient descent to minimize the loss function in machine learning." +
                    "What the learning rate is, why it’s important, and how it impacts results"
                    },
                    new Course()
                    {
                        Id = 3,
                        CourseId = "SQL",
                        CourseName = "Basic SQL",
                        level = Level.Basic,
                        Fee = 6000,
                        TrainingTime = 6,
                        UrlImage = "sql.jpg",
                        Description = "U​se SQL commands to filter, sort, & summarize data; manipulate strings, dates, & numerical data from different sources for analysis." +
                    "U​se the collaborative Databricks workspace and create an end-to-end pipeline that reads data, transforms it, and saves the result." +
                    "A​ssess and create datasets to solve your business questions and problems using SQL." +
                    "Develop a project proposal & select your data, perform statistical analysis & develop metrics, and p​resent your findings & make recommendations"
                    },
                    new Course() { Id = 4, CourseId = "JavaScript", CourseName = "Basic JavaScript", level = Level.Basic, Fee = 6000, TrainingTime = 6, UrlImage = "javascript.jpg", Description = "You will learn programming fundamentals and basic object-oriented concepts using the latest JavaScript syntax. The concepts covered in these lessons lay the foundation for using JavaScript in any environment." },
                    new Course()
                    {
                        Id = 5,
                        CourseId = "JavaScript",
                        CourseName = "Advance JavaScript",
                        level = Level.Advance,
                        Fee = 4275,
                        TrainingTime = 4,
                        UrlImage = "javascriptAd.jpg",
                        Description = "Advanced JavaScript Practices." +
                        "Functional Programming." +
                        "Inheritance + Prototype Chain." +
                        "JavaScript Modules." +
                        "Object Oriented Programming." +
                        "Scope and Execution Context." +
                        "Latest features: ES6, ES7, ES8, ES9, ES10, ES2020." +
                        "Asynchronous JavaScript + Event Loop." +
                        "JavaScript Engine and Runtime." +
                        "Composition vs Inheritance." +
                        "Pass By Reference vs Pass by Value"
                    });

            modelBuilder.Entity<Student>().HasData(
                new Student() { Id = 1, RollNumber = "213004", FirstName = "Ha", LastName = "Van Vu", Address = "Gia Lai", Gmail = "havanvu18@gmail.com", IdentityCard = "001201303446", StudentStatus = StudentStatus.Studying, PhoneNumber = "0825894329", Dob = new DateTime(1990, 02, 13), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 2, RollNumber = "214004", FirstName = "Pham", LastName = "Tung Lam", Address = "Lao Cai", Gmail = "phamlamlc14@gmail.com", IdentityCard = "002302446301", StudentStatus = StudentStatus.Studying, PhoneNumber = "0328658580", Dob = new DateTime(1990, 03, 14), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 3, RollNumber = "215004", FirstName = "Nong", LastName = "Manh Hung", Address = "Cao Bang", Gmail = "nongphanmanhhung93@gmail.com", IdentityCard = "0002304664303", StudentStatus = StudentStatus.Studying, PhoneNumber = "0654871956", Dob = new DateTime(1990, 04, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 4, RollNumber = "216004", FirstName = "Nguyen", LastName = "Trung Anh", Address = "Ha Noi", Gmail = "nguyentrunganh@gmail.com", IdentityCard = "002404356766", StudentStatus = StudentStatus.Studying, PhoneNumber = "0546871264", Dob = new DateTime(1990, 05, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 5, RollNumber = "217004", FirstName = "Do", LastName = "Huu Cong", Address = "Ha Noi", Gmail = "huucong473@gmail.com", IdentityCard = "001201072112", StudentStatus = StudentStatus.Studying, PhoneNumber = "0889567661", Dob = new DateTime(1998, 06, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 6, RollNumber = "213005", FirstName = "Nam", LastName = "Van Va", Address = "Gia Lai", Gmail = "havanvu18@gmail.com", IdentityCard = "001201303433", StudentStatus = StudentStatus.Studying, PhoneNumber = "0825894329", Dob = new DateTime(1998, 02, 13), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 7, RollNumber = "214006", FirstName = "Pha", LastName = "Tung Lang", Address = "Lao Cai", Gmail = "phamlamlc@gmail.com", IdentityCard = "002302446321", StudentStatus = StudentStatus.Studying, PhoneNumber = "0328658581", Dob = new DateTime(1998, 03, 14), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 8, RollNumber = "215007", FirstName = "Nog", LastName = "Manh Hong", Address = "Cao Bang", Gmail = "nongphanmanhhung@gmail.com", IdentityCard = "0002304664323", StudentStatus = StudentStatus.Studying, PhoneNumber = "0654871952", Dob = new DateTime(1998, 04, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 9, RollNumber = "216008", FirstName = "Nguy", LastName = "Trung Tanh", Address = "Ha Noi", Gmail = "nguyentrung@gmail.com", IdentityCard = "002404356266", StudentStatus = StudentStatus.Studying, PhoneNumber = "0546871263", Dob = new DateTime(2000, 05, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 10, RollNumber = "217009", FirstName = "Don", LastName = "Huu Conh", Address = "Ha Noi", Gmail = "huucong47@gmail.com", IdentityCard = "001201072132", StudentStatus = StudentStatus.Studying, PhoneNumber = "0889567664", Dob = new DateTime(1998, 06, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 11, RollNumber = "213010", FirstName = "Han", LastName = "Van Nat", Address = "Gia Lai", Gmail = "havanvu1@gmail.com", IdentityCard = "001201303456", StudentStatus = StudentStatus.Studying, PhoneNumber = "0825894325", Dob = new DateTime(2000, 02, 13), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 12, RollNumber = "214011", FirstName = "Phan", LastName = "Tung Lang", Address = "Lao Cai", Gmail = "phamlamlc1@gmail.com", IdentityCard = "002302446304", StudentStatus = StudentStatus.Studying, PhoneNumber = "0328658586", Dob = new DateTime(2003, 03, 14), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 13, RollNumber = "215012", FirstName = "Non", LastName = "Manh Ganh", Address = "Cao Bang", Gmail = "nongphanhhung93@gmail.com", IdentityCard = "0002304664305", StudentStatus = StudentStatus.Studying, PhoneNumber = "0654871957", Dob = new DateTime(1998, 04, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 14, RollNumber = "216013", FirstName = "Nguy", LastName = "Trung", Address = "Ha Noi", Gmail = "nguyenunganh@gmail.com", IdentityCard = "002404356446", StudentStatus = StudentStatus.Studying, PhoneNumber = "0546871268", Dob = new DateTime(1998, 05, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 15, RollNumber = "217014", FirstName = "Dom", LastName = "Huu", Address = "Ha Noi", Gmail = "huucong473@gmail.com", IdentityCard = "001201072119", StudentStatus = StudentStatus.Studying, PhoneNumber = "0889567669", Dob = new DateTime(2002, 06, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 16, RollNumber = "213015", FirstName = "Ham", LastName = "Van", Address = "Gia Lai", Gmail = "havau18@gmail.com", IdentityCard = "001201303447", StudentStatus = StudentStatus.Studying, PhoneNumber = "0825894311", Dob = new DateTime(1998, 02, 13), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 17, RollNumber = "214016", FirstName = "Phat", LastName = "Tung", Address = "Lao Cai", Gmail = "phlamlc14@gmail.com", IdentityCard = "002302446311", StudentStatus = StudentStatus.Studying, PhoneNumber = "0328658512", Dob = new DateTime(1997, 03, 14), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 18, RollNumber = "215017", FirstName = "Nong", LastName = "Manh", Address = "Cao Bang", Gmail = "nonhanmanhhung93@gmail.com", IdentityCard = "0002304664312", StudentStatus = StudentStatus.Studying, PhoneNumber = "0654871913", Dob = new DateTime(1998, 04, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 19, RollNumber = "216018", FirstName = "Nguyen", LastName = "Anh", Address = "Ha Noi", Gmail = "ngentrunganh@gmail.com", IdentityCard = "002404356713", StudentStatus = StudentStatus.Studying, PhoneNumber = "0546871214", Dob = new DateTime(1999, 05, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 20, RollNumber = "217019", FirstName = "Do", LastName = "Cong", Address = "Ha Noi", Gmail = "hcong473@gmail.com", IdentityCard = "001201072114", StudentStatus = StudentStatus.Studying, PhoneNumber = "0889567615", Dob = new DateTime(1999, 06, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },

                new Student() { Id = 21, RollNumber = "213154", FirstName = "Ha", LastName = "Van Vu", Address = "Gia Lai", Gmail = "havanvuuo@gmail.com", IdentityCard = "001201301146", StudentStatus = StudentStatus.Studying, PhoneNumber = "0825894300", Dob = new DateTime(1990, 02, 13), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 22, RollNumber = "214154", FirstName = "Pham", LastName = "Tung Lam", Address = "Lao Cai", Gmail = "phauoamlc14@gmail.com", IdentityCard = "002322446399", StudentStatus = StudentStatus.Studying, PhoneNumber = "0328658500", Dob = new DateTime(1990, 03, 14), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 23, RollNumber = "215154", FirstName = "Nong", LastName = "Manh Hung", Address = "Cao Bang", Gmail = "nuogphanmanhhung93@gmail.com", IdentityCard = "0003304664389", StudentStatus = StudentStatus.Studying, PhoneNumber = "0654871950", Dob = new DateTime(1990, 04, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 24, RollNumber = "216154", FirstName = "Nguyen", LastName = "Trung Anh", Address = "Ha Noi", Gmail = "nuoyentrunganh@gmail.com", IdentityCard = "002404356798", StudentStatus = StudentStatus.Studying, PhoneNumber = "0546871260", Dob = new DateTime(1990, 05, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 25, RollNumber = "217154", FirstName = "Do", LastName = "Huu Cong", Address = "Ha Noi", Gmail = "huuconuo73@gmail.com", IdentityCard = "001201072122", StudentStatus = StudentStatus.Studying, PhoneNumber = "0889567662", Dob = new DateTime(1998, 06, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 26, RollNumber = "213155", FirstName = "Nam", LastName = "Van Va", Address = "Gia Lai", Gmail = "havanvuo8@gmail.com", IdentityCard = "001201303434", StudentStatus = StudentStatus.Studying, PhoneNumber = "0825894325", Dob = new DateTime(1998, 02, 13), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 27, RollNumber = "214156", FirstName = "Pha", LastName = "Tung Lang", Address = "Lao Cai", Gmail = "phauoamlc@gmail.com", IdentityCard = "002302446521", StudentStatus = StudentStatus.Studying, PhoneNumber = "0328658511", Dob = new DateTime(1998, 03, 14), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 28, RollNumber = "215157", FirstName = "Nog", LastName = "Manh Hong", Address = "Cao Bang", Gmail = "nouophanmanhhung@gmail.com", IdentityCard = "0012304664323", StudentStatus = StudentStatus.Studying, PhoneNumber = "0654871915", Dob = new DateTime(1998, 04, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 29, RollNumber = "216158", FirstName = "Nguy", LastName = "Trung Tanh", Address = "Ha Noi", Gmail = "nguoentrung@gmail.com", IdentityCard = "102404356266", StudentStatus = StudentStatus.Studying, PhoneNumber = "0546871222", Dob = new DateTime(2000, 05, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 30, RollNumber = "217159", FirstName = "Don", LastName = "Huu Conh", Address = "Ha Noi", Gmail = "huucouo47@gmail.com", IdentityCard = "101201072132", StudentStatus = StudentStatus.Studying, PhoneNumber = "0889567644", Dob = new DateTime(1998, 06, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 31, RollNumber = "213150", FirstName = "Han", LastName = "Van Nat", Address = "Gia Lai", Gmail = "havanuo1@gmail.com", IdentityCard = "101201303456", StudentStatus = StudentStatus.Studying, PhoneNumber = "0825894377", Dob = new DateTime(2000, 02, 13), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 32, RollNumber = "214151", FirstName = "Phan", LastName = "Tung Lang", Address = "Lao Cai", Gmail = "phuolamlc1@gmail.com", IdentityCard = "102302446304", StudentStatus = StudentStatus.Studying, PhoneNumber = "0328658555", Dob = new DateTime(2003, 03, 14), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 33, RollNumber = "215152", FirstName = "Non", LastName = "Manh Ganh", Address = "Cao Bang", Gmail = "nouophanhhung93@gmail.com", IdentityCard = "0102304664305", StudentStatus = StudentStatus.Studying, PhoneNumber = "0654871955", Dob = new DateTime(1998, 04, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 34, RollNumber = "216153", FirstName = "Nguy", LastName = "Trung", Address = "Ha Noi", Gmail = "nguyennuuoanh@gmail.com", IdentityCard = "102404356446", StudentStatus = StudentStatus.Studying, PhoneNumber = "0546871268", Dob = new DateTime(1998, 05, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 35, RollNumber = "217154", FirstName = "Dom", LastName = "Huu", Address = "Ha Noi", Gmail = "huucouyen73@gmail.com", IdentityCard = "101201072119", StudentStatus = StudentStatus.Studying, PhoneNumber = "0889567619", Dob = new DateTime(2002, 06, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 36, RollNumber = "213155", FirstName = "Ham", LastName = "Van", Address = "Gia Lai", Gmail = "havauyen@gmail.com", IdentityCard = "011201303447", StudentStatus = StudentStatus.Studying, PhoneNumber = "0825894315", Dob = new DateTime(1998, 02, 13), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 37, RollNumber = "214156", FirstName = "Phat", LastName = "Tung", Address = "Lao Cai", Gmail = "phuyenlc14@gmail.com", IdentityCard = "102302446311", StudentStatus = StudentStatus.Studying, PhoneNumber = "0328658514", Dob = new DateTime(1997, 03, 14), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 38, RollNumber = "215157", FirstName = "Nong", LastName = "Manh", Address = "Cao Bang", Gmail = "nuyenanmanhhung93@gmail.com", IdentityCard = "0012304664312", StudentStatus = StudentStatus.Studying, PhoneNumber = "0654871913", Dob = new DateTime(1998, 04, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 39, RollNumber = "216158", FirstName = "Nguyen", LastName = "Anh", Address = "Ha Noi", Gmail = "nguyenrunganh@gmail.com", IdentityCard = "012404356713", StudentStatus = StudentStatus.Studying, PhoneNumber = "0546871212", Dob = new DateTime(1999, 05, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 40, RollNumber = "217159", FirstName = "Do", LastName = "Cong", Address = "Ha Noi", Gmail = "hconguyen@gmail.com", IdentityCard = "011201072114", StudentStatus = StudentStatus.Studying, PhoneNumber = "0889567611", Dob = new DateTime(1999, 06, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 });

            modelBuilder.Entity<ClassStudy>().HasData(
                new ClassStudy() { Id = 1, ClassId = "CT207", Name = "Basic Java", StartTime = new DateTime(2021, 1, 10), EndTime = new DateTime(2021, 7, 10), TeacherId = 1 },
                new ClassStudy() { Id = 2, ClassId = "CT208", Name = "Basic Python", StartTime = new DateTime(2021, 2, 11), EndTime = new DateTime(2021, 8, 11), TeacherId = 2 },
                new ClassStudy() { Id = 3, ClassId = "CT209", Name = "Basic SQL", StartTime = new DateTime(2021, 4, 5), EndTime = new DateTime(2021, 10, 5), TeacherId = 3 },
                new ClassStudy() { Id = 4, ClassId = "CT210", Name = "Basic JavaScript ", StartTime = new DateTime(2021, 4, 10), EndTime = new DateTime(2021, 10, 10), TeacherId = 4 },
                new ClassStudy() { Id = 5, ClassId = "CT211", Name = "Advance JavaScript", StartTime = new DateTime(2021, 1, 15), EndTime = new DateTime(2021, 5, 15), TeacherId = 5 },
                new ClassStudy() { Id = 6, ClassId = "CT212", Name = "Advance Python", StartTime = new DateTime(2021, 5, 4), EndTime = new DateTime(2021, 9, 4), TeacherId = 6 });

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
                new Customer() { Id = 1, Name = "Tran Thi Tuyet", Gmail = "tuyettranlc4@gmail.com", PhoneNumber = "0395761476", Contents = "What is the school's facilities and teaching quality like?", CreatingDate = DateTime.Now, customerStatus = CustomerStatus.Confirm, TestRoomId = 1 },
                new Customer() { Id = 2, Name = "Nguyen Van Ngoc", Gmail = "ngocdra@gmail.com", PhoneNumber = "0956137845", Contents = "What will I get during my studies? ", CreatingDate = DateTime.Now, customerStatus = CustomerStatus.Confirm, TestRoomId = 1 },
                new Customer() { Id = 3, Name = "Nguyen Hoai Nam", Gmail = "namot@gmail.com", PhoneNumber = "0986176340", Contents = "Can I take other experiential sessions outside the main school hours?", CreatingDate = DateTime.Now, customerStatus = CustomerStatus.Confirm, TestRoomId = 1 },
                new Customer() { Id = 4, Name = "Pham Tuyet Mai", Gmail = "maioklc@gmail.com", PhoneNumber = "0296753186", Contents = "Can I make a reservation if I miss a midterm?", CreatingDate = DateTime.Now, customerStatus = CustomerStatus.Confirm, TestRoomId = 1 },
                new Customer() { Id = 5, Name = "Le Quang Tho", Gmail = "thobeo8@gmail.com", PhoneNumber = "0364781029", Contents = "Can I leave the course for the next semester too?", CreatingDate = DateTime.Now, customerStatus = CustomerStatus.Confirm, TestRoomId = 1 },
                new Customer() { Id = 6, Name = "Tran Thi Tan", Gmail = "tuyettanl@gmail.com", PhoneNumber = "0395761111", Contents = "What is the school's facilities and teaching quality like?", CreatingDate = DateTime.Now, customerStatus = CustomerStatus.Uncomfirm },
                new Customer() { Id = 7, Name = "Nguyen Van Thai", Gmail = "thaidra@gmail.com", PhoneNumber = "0956137222", Contents = "What will I get during my studies? ", CreatingDate = DateTime.Now, customerStatus = CustomerStatus.Uncomfirm },
                new Customer() { Id = 8, Name = "Nguyen Hoai Van", Gmail = "Vanot@gmail.com", PhoneNumber = "0986176333", Contents = "Can I take other experiential sessions outside the main school hours?", CreatingDate = DateTime.Now, customerStatus = CustomerStatus.Uncomfirm },
                new Customer() { Id = 9, Name = "Pham Tuyet Tho", Gmail = "thoklc@gmail.com", PhoneNumber = "0296753144", Contents = "Can I make a reservation if I miss a midterm?", CreatingDate = DateTime.Now, customerStatus = CustomerStatus.Uncomfirm },
                new Customer() { Id = 10, Name = "Le Quang Hai", Gmail = "haibeo8@gmail.com", PhoneNumber = "0364781055", Contents = "Can I leave the course for the next semester too?", CreatingDate = DateTime.Now, customerStatus = CustomerStatus.Uncomfirm });

            modelBuilder.Entity<RegistrationTest>().HasData(
                new RegistrationTest() { Id = 1, CourseName = "Basic Java", RegistrationFee = 100, CustomerId = 1 },
                new RegistrationTest() { Id = 2, CourseName = "Advance Python", RegistrationFee = 100, CustomerId = 2 },
                new RegistrationTest() { Id = 3, CourseName = "Basic SQL", RegistrationFee = 100, CustomerId = 3 },
                new RegistrationTest() { Id = 4, CourseName = "Advance JavaScript", RegistrationFee = 100, CustomerId = 4 },
                new RegistrationTest() { Id = 5, CourseName = "Basic Network Security", RegistrationFee = 100, CustomerId = 5 },
                new RegistrationTest() { Id = 6, CourseName = "Basic Java", RegistrationFee = 100, CustomerId = 6 },
                new RegistrationTest() { Id = 7, CourseName = "Advance Python", RegistrationFee = 100, CustomerId = 7 },
                new RegistrationTest() { Id = 8, CourseName = "Basic SQL", RegistrationFee = 100, CustomerId = 8 },
                new RegistrationTest() { Id = 9, CourseName = "Advance JavaScript", RegistrationFee = 100, CustomerId = 9 },
                new RegistrationTest() { Id = 10, CourseName = "Basic Network Security", RegistrationFee = 100, CustomerId = 10 });

            modelBuilder.Entity<Teacher>().HasData(
              new Teacher()
              {
                  Id = 1,
                  FirstName = "Miranda",
                  LastName = "Jude",
                  Dob = new DateTime(1964, 02, 13),
                  Gmail = "JudeMiranda@gmail.com",
                  Major = "Python, Data Science",
                  Address = "Andheri East, Mumbai, Maharashtra, India",
                  UrlImage = "jude.jpg"
              },
              new Teacher()
              {
                  Id = 2,
                  Dob = new DateTime(1974, 02, 23),
                  Address = "Islamabad Expressway, I 8/4 I-8, Islamabad, Islamabad Capital Territory, Pakistan",
                  FirstName = "Nadeem",
                  LastName = "Mehmood",
                  Gmail = "Nadeem@gmail.com",
                  Major = "JAVA, Mechanical Engineering",
                  UrlImage = "nadeem.jpg"
              },
              new Teacher()
              {
                  Id = 3,
                  FirstName = "Sagar",
                  LastName = "Yadav",
                  Dob = new DateTime(1984, 04, 15),
                  Gmail = "Yadav@gmail.com",
                  Major = "JavaScript, Deep Learning, C++",
                  Address = "Pune, Maharashtra, India",
                  UrlImage = "sagar.png"
              },
              new Teacher()
              {
                  Id = 4,
                  Dob = new DateTime(1978, 01, 03),
                  Address = "Ameerpet, Hyderabad, Telangana, India",
                  FirstName = "Surya",
                  LastName = "Reddy",
                  Gmail = "Reddy@gmail.com",
                  Major = "Core JAVA, Angular 2,Spring MVC, SQL",
                  UrlImage = "surya.jpg"
              },
              new Teacher()
              {
                  Id = 5,
                  Dob = new DateTime(1984, 12, 18),
                  Address = "Abbottabad, Khyber Pakhtunkhwa, Pakistan",
                  FirstName = "Muhammad",
                  LastName = "Ubaid",
                  Gmail = "Ubaid@gmail.com",
                  Major = "Java Programming,Java Data Structures, Data Science",
                  UrlImage = "ubaid.jpg"
              },
              new Teacher()
              {
                  Id = 6,
                  Dob = new DateTime(1994, 12, 28),
                  Address = "BTM 2nd Stage, Bengaluru, Karnataka, India",
                  FirstName = "Arvind",
                  LastName = "Carpenter",
                  Gmail = "Arvind@gmail.com",
                  Major = "JAVA ,SQL, Mongo DB, VueJS",
                  UrlImage = "arvind.jpg"
              },
              new Teacher()
              {
                  Id = 7,
                  Dob = new DateTime(1991, 12, 18),
                  Address = "Vaniyambadi, Tamil Nadu, India",
                  FirstName = "Ks Sri",
                  LastName = "Nandhish",
                  Gmail = "Nandhish@gmail.com",
                  Major = "Java, Python",
                  UrlImage = "ks.jpg"
              },
              new Teacher()
              {
                  Id = 8,
                  Dob = new DateTime(1989, 11, 18),
                  Address = "Dwarka, New Delhi, Delhi, India",
                  FirstName = "Aakash",
                  LastName = "Madan",
                  Gmail = "Madan@gmail.com",
                  Major = "Java Programming,Java Data Structures, Data Science",
                  UrlImage = "aakash.jpg"
              }

            );

            modelBuilder.Entity<ResultTest>().HasData(
                new ResultTest() { Id = 1, RollNumber = "TH1907027", ClassName = "TM1909M", CourseName = "Basic Java", LastName = "Nguyen", FirstName = "Sang", Gmail = "sang@gmail.com", Dob = new DateTime(1999, 10, 1), Fee = 6000, SubFee = 0, LastDayPayment = new DateTime(2021, 4, 21) },
                new ResultTest() { Id = 2, RollNumber = "TH1908028", ClassName = "TM1909M", CourseName = "Basic Java", LastName = "Nguyen", FirstName = "Hieu", Gmail = "hieu@gmail.com", Dob = new DateTime(1998, 11, 2), Fee = 6000, SubFee = 1000, LastDayPayment = new DateTime(2021, 4, 21) },
                new ResultTest() { Id = 3, RollNumber = "TH1908029", ClassName = "TM1909M", CourseName = "Basic Java", LastName = "Nguyen", FirstName = "Ty", Gmail = "nguyenty@gmail.com", Dob = new DateTime(1998, 1, 3), Fee = 6000, SubFee = 1000, LastDayPayment = new DateTime(2021, 4, 21) },
                new ResultTest() { Id = 4, RollNumber = "TH1908039", ClassName = "TM1909M", CourseName = "Basic Java", LastName = "Mai", FirstName = "Truong", Gmail = "truongmai@gmail.com", Dob = new DateTime(1999, 10, 4), Fee = 6000, SubFee = 0, LastDayPayment = new DateTime(2021, 4, 21) },
                new ResultTest() { Id = 5, RollNumber = "TH1908045", ClassName = "TM1909M", CourseName = "Basic Java", LastName = "Pham", FirstName = "Tuan", Gmail = "phantuan@gmail.com", Dob = new DateTime(1999, 2, 1), Fee = 6000, SubFee = 1000, LastDayPayment = new DateTime(2021, 4, 21) },
                new ResultTest() { Id = 6, RollNumber = "TH1908050", ClassName = "TM1909M", CourseName = "Basic Java", LastName = "Nong", FirstName = "Hung", Gmail = "nonghung@gmail.com", Dob = new DateTime(2000, 1, 15), Fee = 6000, SubFee = 0, LastDayPayment = new DateTime(2021, 4, 21) },
                new ResultTest() { Id = 7, RollNumber = "TH1908052", ClassName = "TM1909M", CourseName = "Basic Java", LastName = "Nhu", FirstName = "Duc", Gmail = "nhuduc@gmail.com", Dob = new DateTime(1999, 5, 10), Fee = 6000, SubFee = 1000, LastDayPayment = new DateTime(2021, 4, 21) },
                new ResultTest() { Id = 8, RollNumber = "TH1908054", ClassName = "TM1909M", CourseName = "Basic Java", LastName = "Pham", FirstName = "Tu", Gmail = "phamtu@gmail.com", Dob = new DateTime(2001, 4, 12), Fee = 6000, SubFee = 0, LastDayPayment = new DateTime(2021, 4, 21) },
                new ResultTest() { Id = 9, RollNumber = "TH1908055", ClassName = "TM1909M", CourseName = "Basic Java", LastName = "Ha", FirstName = "Tung", Gmail = "hatung@gmail.com", Dob = new DateTime(2002, 3, 13), Fee = 6000, SubFee = 0, LastDayPayment = new DateTime(2021, 4, 21) },
                new ResultTest() { Id = 10, RollNumber = "TH1908059", ClassName = "TM1909P", CourseName = "Basic Python", LastName = "Nguyen", FirstName = "Anh", Gmail = "nguyenanh@gmail.com", Dob = new DateTime(1999, 10, 6), Fee = 6000, SubFee = 0, LastDayPayment = new DateTime(2021, 4, 21) },
                new ResultTest() { Id = 11, RollNumber = "TH1908060", ClassName = "TM1909P", CourseName = "Basic Python", LastName = "Truong", FirstName = "Tu", Gmail = "truongtu@gmail.com", Dob = new DateTime(1999, 7, 12), Fee = 6000, SubFee = 1000, LastDayPayment = new DateTime(2021, 4, 21) },
                new ResultTest() { Id = 12, RollNumber = "TH1908062", ClassName = "TM1909P", CourseName = "Basic Python", LastName = "Do", FirstName = "Cong", Gmail = "dongcong@gmail.com", Dob = new DateTime(1999, 8, 18), Fee = 6000, SubFee = 1000, LastDayPayment = new DateTime(2021, 4, 21) },
                new ResultTest() { Id = 13, RollNumber = "TH1908066", ClassName = "TM1909P", CourseName = "Basic Python", LastName = "Nguyen", FirstName = "Phong", Gmail = "nguyenphong@gmail.com", Dob = new DateTime(1999, 10, 4), Fee = 6000, SubFee = 1000, LastDayPayment = new DateTime(2021, 4, 21) },
                new ResultTest() { Id = 14, RollNumber = "TH1909001", ClassName = "TM1909P", CourseName = "Basic Python", LastName = "Do", FirstName = "Hoa", Gmail = "dohoa@gmail.com", Dob = new DateTime(1999, 12, 20), Fee = 6000, SubFee = 1000, LastDayPayment = new DateTime(2021, 4, 21) },
                new ResultTest() { Id = 15, RollNumber = "TH1909002", ClassName = "TM1909P", CourseName = "Basic Python", LastName = "Nguyen", FirstName = "Thuan", Gmail = "nguyenthuan@gmail.com", Dob = new DateTime(1996, 10, 11), Fee = 6000, SubFee = 1000, LastDayPayment = new DateTime(2021, 4, 21) },
                new ResultTest() { Id = 16, RollNumber = "TH1909003", ClassName = "TM1909P", CourseName = "Basic Python", LastName = "Vu", FirstName = "Huy", Gmail = "vuhuy@gmail.com", Dob = new DateTime(1992, 11, 13), Fee = 6000, SubFee = 1000, LastDayPayment = new DateTime(2021, 4, 21) },
                new ResultTest() { Id = 17, RollNumber = "TH1908046", ClassName = "TM1909P", CourseName = "Basic Python", LastName = "Pham", FirstName = "Vuong", Gmail = "phamvuong@gmail.com", Dob = new DateTime(1994, 10, 25), Fee = 6000, SubFee = 0, LastDayPayment = new DateTime(2021, 4, 21) }
                );

            modelBuilder.Entity<Examination>().HasData(
                new Examination() { Id = 1, CourseId = "Java", Fee = 0, TestDay = new DateTime(2021, 5, 20), Note = "" },
                new Examination() { Id = 2, CourseId = "Python", Fee = 0, TestDay = new DateTime(2021, 5, 20), Note = "" },
                new Examination() { Id = 3, CourseId = "SQL", Fee = 0, TestDay = new DateTime(2021, 5, 20), Note = "" },
                new Examination() { Id = 4, CourseId = "JavaScript", Fee = 0, TestDay = new DateTime(2021, 5, 20), Note = "" },
                new Examination() { Id = 5, CourseId = "Java", Fee = 0, TestDay = new DateTime(2021, 6, 20), Note = "" },
                new Examination() { Id = 6, CourseId = "Java", Fee = 0, TestDay = new DateTime(2021, 8, 20), Note = "" },
                new Examination() { Id = 7, CourseId = "JavaScript", Fee = 0, TestDay = new DateTime(2021, 6, 20), Note = "" },
                new Examination() { Id = 8, CourseId = "Python", Fee = 0, TestDay = new DateTime(2021, 6, 20), Note = "" }
                );
            modelBuilder.Entity<TestRoom>().HasData(
          new TestRoom() { Id = 1, Name = "Room 1" },
          new TestRoom() { Id = 2, Name = "Room 2" });

            modelBuilder.Entity<Post>().HasData(
           new Post() { Id = 1, Title = "We Are Symphony Learning Center", content = "Symphony Ltd. is private institute, which generally conducts the classes and training materials for the various certifications that are related to IT and Software industries like networking related, Java related, database related like for SQL Servers, oracle, etc. They are one of the famous institutions which have spread in to various branches situated at different location in the state. They provide various resources like the preparation materials, lab facilities based on the subject, extra lab hours or sessions (offered after the course duration), 24 hours faculty guidance is provided for the lab sessions, assignments, Library facilities, etc.", Author = " ", CreateDate = DateTime.Now.Date, UrlImage = "about.jpg" }
           );
        }
    }
}