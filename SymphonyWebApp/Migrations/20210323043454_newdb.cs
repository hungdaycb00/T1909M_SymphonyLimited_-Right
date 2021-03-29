﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SymphonyWebApp.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Centres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Centres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClassStudies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassStudies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false),
                    UrlImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Contents = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Local)),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassStudyCourse",
                columns: table => new
                {
                    ClassStudiesId = table.Column<int>(type: "int", nullable: false),
                    CoursesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassStudyCourse", x => new { x.ClassStudiesId, x.CoursesId });
                    table.ForeignKey(
                        name: "FK_ClassStudyCourse_ClassStudies_ClassStudiesId",
                        column: x => x.ClassStudiesId,
                        principalTable: "ClassStudies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassStudyCourse_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RollNumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdentityCard = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FeeStatus = table.Column<int>(type: "int", nullable: false),
                    StudentStatus = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CourseId = table.Column<int>(type: "int", unicode: false, maxLength: 10, nullable: false),
                    ClassId = table.Column<int>(type: "int", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_ClassStudies_ClassId",
                        column: x => x.ClassId,
                        principalTable: "ClassStudies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistrationTests_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Centres",
                columns: new[] { "Id", "Address" },
                values: new object[,]
                {
                    { 1, "Phu Xuyen-Ha Noi" },
                    { 2, "5 Nguyen Van Loc- Ha Dong- Ha Noi" },
                    { 3, "56-Van Phu-Ha Dong" },
                    { 4, "119 Thanh Xuan-Ha Dong " },
                    { 5, "5 Pham Hung- My Dinh-Ha Noi" }
                });

            migrationBuilder.InsertData(
                table: "ClassStudies",
                columns: new[] { "Id", "ClassId", "EndTime", "Name", "StartTime" },
                values: new object[,]
                {
                    { 1, "CT207", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basic Java", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "CT208", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basic Python", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "CT209", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basic SQL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "CT210", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basic JavaScript ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "CT211", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bacic Network Security", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseId", "CourseName", "Fee", "TrainingTime", "UrlImage", "level" },
                values: new object[,]
                {
                    { 5, "Security", "Basic Network Security", 4275m, 4, null, 0 },
                    { 3, "SQL", " Basic SQL", 4275m, 4, null, 0 },
                    { 4, "JavaScript", "Basic JavaScript", 6000m, 6, null, 0 },
                    { 1, "Java", "Basic Java", 6000m, 6, null, 0 },
                    { 2, "Python", "Basic Python", 6000m, 6, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Contents", "Gmail", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "What is the school's facilities and teaching quality like?", "tuyettranlc4@gmail.com", "Tran Thi Tuyet", "0395761476" },
                    { 2, "What will I get during my studies? ", "ngocdra@gmail.com", "Nguyen Van Ngoc", "0956137845" },
                    { 3, "Can I take other experiential sessions outside the main school hours?", "namot@gmail.com", "Nguyen Hoai Nam", "0986176340" },
                    { 4, "Can I make a reservation if I miss a midterm?", "maioklc@gmail.com", "Pham Tuyet Mai", "0296753186" },
                    { 5, "Can I leave the course for the next semester too?", "thobeo8@gmail.com", "Le Quang Tho", "0364781029" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Answer", "Title" },
                values: new object[,]
                {
                    { 6, "Ans: Yes there will be and it will be available on the application form", "Will there be any fees for the entrance exam? " },
                    { 1, "On this the admin should be able to enter or update the procedures for joining the course that the institute offers", "How to join the course?" },
                    { 2, "The various benefits that the student can gain by joining the institution is to be provided", "Why to join the institute? " },
                    { 3, "Once in 6 months, and one need to check the website for knowing when is the entrance exam entitled, the fees for the entrance exam (admin will decide and displayed on the application form)", "When will be Entrance Examinations Conducted? " },
                    { 4, "Will there be any extra hidden charges? (Ans: Yes, you can use the lab sessions even after your class hours. There will be no charges during the course days (i.e., during the course period if you want to use the lab sessions after the class hours we do provide the lab session and the labs will be kept opened till 9 PM in the evening. But yes if you want to use the lab session after your course completion, then it will be charged based on the scenario (like 1000$ if opted at the time of registering and 1500$ if opted after the completion of the course)", "Can I use the Lab facilities after my class hours? " },
                    { 5, "Ans: once the entrance exams are entitled, one need to visit the centre for applying it through paper and fill all the necessary details through online. On the application form one should chose which course he/she wanted to pursue.", "How can I apply for the entrance exam? " },
                    { 7, "Ans: payment can be done through draft, or through cheque or through cash. For making the payment through cash, one needs to come to one of the centre of the institute, and make the payment there itself. Once the payment is done (through cash or through DD), the student will be provided with the receipt with a receipt number. This receipt number is to be inputted in the application form. For the payments done through cheque and DD, one need to enter the DD number and the cheque number, bank details, etc. are to be entered on the application form and the cheque is to be pinned to the application form. Only once the payment is received the student’s application will be accepted. Once the application is accepted, the student is mailed with the acknowledgement form along with the details of the examination, subject chosen, date and time of exam, and the roll number", "How to make the payment? " }
                });

            migrationBuilder.InsertData(
                table: "RegistrationTests",
                columns: new[] { "Id", "CourseName", "CustomerId", "RegistrationFee" },
                values: new object[,]
                {
                    { 1, "Basic Java", 1, 100m },
                    { 2, "Basic Python", 2, 100m },
                    { 3, "Basic SQL", 3, 100m },
                    { 4, "Basic JavaScript", 4, 100m },
                    { 5, "Basic Network Security", 5, 100m }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "ClassId", "CourseId", "Dob", "FeeStatus", "FirstName", "Gmail", "IdentityCard", "LastName", "PhoneNumber", "RollNumber", "SubFee" },
                values: new object[,]
                {
                    { 1, "Gia Lai", 1, 1, new DateTime(2020, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ha", "havanvu18@gmail.com", "001201303446", "Van Vu", "0825894329", "21304", 1000m },
                    { 2, "Lao Cai", 2, 2, new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Pham", "phamlamlc14@gmail.com", "002302446301", "Tung Lam", "0328658580", "21404", 1000m },
                    { 3, "Cao Bang", 3, 3, new DateTime(2020, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Nong", "nongphanmanhhung93@gmail.com", "0002304664303", "Manh Hung", "0654871956", "21504", 1000m },
                    { 4, "Ha Noi", 4, 4, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Nguyen", "nguyentrunganh@gmail.com", "002404356766", "Trung Anh", "0546871264", "21604", 1000m },
                    { 5, "Ha Noi", 5, 5, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Do", "huucong473@gmail.com", "001201072112", "Huu Cong", "0889567661", "21704", 1000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClassStudyCourse_CoursesId",
                table: "ClassStudyCourse",
                column: "CoursesId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationTests_CustomerId",
                table: "RegistrationTests",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseId",
                table: "Students",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Centres");

            migrationBuilder.DropTable(
                name: "ClassStudyCourse");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "RegistrationTests");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ClassStudies");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}