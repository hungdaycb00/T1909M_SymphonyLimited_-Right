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
                        UrlImage = "pythonAd.png",
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
                        UrlImage = "sql.png",
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
                new Student() { Id = 1, RollNumber = "21304", FirstName = "Ha", LastName = "Van Vu", Address = "Gia Lai", Gmail = "havanvu18@gmail.com", IdentityCard = "001201303446", StudentStatus = StudentStatus.Active, PhoneNumber = "0825894329", Dob = new DateTime(2020, 02, 13), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 1, CourseId = 1 },
                new Student() { Id = 2, RollNumber = "21404", FirstName = "Pham", LastName = "Tung Lam", Address = "Lao Cai", Gmail = "phamlamlc14@gmail.com", IdentityCard = "002302446301", StudentStatus = StudentStatus.Active, PhoneNumber = "0328658580", Dob = new DateTime(2020, 03, 14), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 2, CourseId = 2 },
                new Student() { Id = 3, RollNumber = "21504", FirstName = "Nong", LastName = "Manh Hung", Address = "Cao Bang", Gmail = "nongphanmanhhung93@gmail.com", IdentityCard = "0002304664303", StudentStatus = StudentStatus.Active, PhoneNumber = "0654871956", Dob = new DateTime(2020, 04, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 3, CourseId = 3 },
                new Student() { Id = 4, RollNumber = "21604", FirstName = "Nguyen", LastName = "Trung Anh", Address = "Ha Noi", Gmail = "nguyentrunganh@gmail.com", IdentityCard = "002404356766", StudentStatus = StudentStatus.Active, PhoneNumber = "0546871264", Dob = new DateTime(2020, 05, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 4, CourseId = 4 },
                new Student() { Id = 5, RollNumber = "21704", FirstName = "Do", LastName = "Huu Cong", Address = "Ha Noi", Gmail = "huucong473@gmail.com", IdentityCard = "001201072112", StudentStatus = StudentStatus.Active, PhoneNumber = "0889567661", Dob = new DateTime(2020, 06, 15), SubFee = 1000, FeeStatus = FeeStatus.Paid, ClassId = 5, CourseId = 5 });

            modelBuilder.Entity<ClassStudy>().HasData(
                new ClassStudy() { Id = 1, ClassId = "CT207", Name = "Basic Java" },
                new ClassStudy() { Id = 2, ClassId = "CT208", Name = "Basic Python" },
                new ClassStudy() { Id = 3, ClassId = "CT209", Name = "Basic SQL" },
                new ClassStudy() { Id = 4, ClassId = "CT210", Name = "Basic JavaScript " },
                new ClassStudy() { Id = 5, ClassId = "CT211", Name = "Advance JavaScript" },
                new ClassStudy() { Id = 6, ClassId = "CT212", Name = "Advance Python" });

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
                new Customer() { Id = 5, Name = "Le Quang Tho", Gmail = "thobeo8@gmail.com", PhoneNumber = "0364781029", Contents = "Can I leave the course for the next semester too?" },
                new Customer() { Id = 6, Name = "Tran Thi Tan", Gmail = "tuyettanl@gmail.com", PhoneNumber = "0395761111", Contents = "What is the school's facilities and teaching quality like?" },
                new Customer() { Id = 7, Name = "Nguyen Van Thai", Gmail = "thaidra@gmail.com", PhoneNumber = "0956137222", Contents = "What will I get during my studies? " },
                new Customer() { Id = 8, Name = "Nguyen Hoai Van", Gmail = "Vanot@gmail.com", PhoneNumber = "0986176333", Contents = "Can I take other experiential sessions outside the main school hours?" },
                new Customer() { Id = 9, Name = "Pham Tuyet Tho", Gmail = "thoklc@gmail.com", PhoneNumber = "0296753144", Contents = "Can I make a reservation if I miss a midterm?" },
                new Customer() { Id = 10, Name = "Le Quang Hai", Gmail = "haibeo8@gmail.com", PhoneNumber = "0364781055", Contents = "Can I leave the course for the next semester too?" });

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
        }
    }
}