using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SymphonyWebApp.Migrations
{
    public partial class updateCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ClassStudies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Advance JavaScript");

            migrationBuilder.InsertData(
                table: "ClassStudies",
                columns: new[] { "Id", "ClassId", "EndTime", "Name", "StartTime" },
                values: new object[] { 6, "CT212", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Advance Python", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "UrlImage" },
                values: new object[] { "How to write Java Programs from scratch and have loads of fun in the processGain enough experience to pass a core Java Programming interview and perform well on the job,Go from zero to hero in writing industry ready Java programs", "java.jpg" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "UrlImage" },
                values: new object[] { "Install Python and write your first program.Describe the basics of the Python programming language.Use variables to store, retrieve and calculate information.Utilize core programming tools such as functions and loops", "python.jpg" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseName", "Description", "Fee", "TrainingTime", "UrlImage" },
                values: new object[] { "Basic SQL", "U​se SQL commands to filter, sort, & summarize data; manipulate strings, dates, & numerical data from different sources for analysis.U​se the collaborative Databricks workspace and create an end-to-end pipeline that reads data, transforms it, and saves the result.A​ssess and create datasets to solve your business questions and problems using SQL.Develop a project proposal & select your data, perform statistical analysis & develop metrics, and p​resent your findings & make recommendations", 6000m, 6, "sql.png" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "UrlImage" },
                values: new object[] { "You will learn programming fundamentals and basic object-oriented concepts using the latest JavaScript syntax. The concepts covered in these lessons lay the foundation for using JavaScript in any environment.", "javascript.jpg" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "CourseName", "Description", "UrlImage", "level" },
                values: new object[] { "JavaScript", "Advance JavaScript", "Advanced JavaScript Practices.Functional Programming.Inheritance + Prototype Chain.JavaScript Modules.Object Oriented Programming.Scope and Execution Context.Latest features: ES6, ES7, ES8, ES9, ES10, ES2020.Asynchronous JavaScript + Event Loop.JavaScript Engine and Runtime.Composition vs Inheritance.Pass By Reference vs Pass by Value", "javascript.jpg", 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseId", "CourseName", "Description", "Fee", "TrainingTime", "UrlImage", "level" },
                values: new object[,]
                {
                    { 6, "Java", "Advance Java", "How to navigate and use the NetBeans IDE to create Java projects, packages and programs.How to declare and use Java Datatypes & Identifiers, work with Java Operators,  work with Java Decision Making Constructs.How to work with Java repetition/Looping Constructs, declare and use Java Arrays, as well as work with the Java Exception Handling mechanism.", 4275m, 4, "javaAd.jpg", 1 },
                    { 7, "Python", "Advance Python", "How gradient descent and stochastic gradient descent algorithms work.How to apply gradient descent and stochastic gradient descent to minimize the loss function in machine learning.What the learning rate is, why it’s important, and how it impacts results", 4275m, 4, "pythonAd.png", 1 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Contents", "Gmail", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 6, "What is the school's facilities and teaching quality like?", "tuyettanl@gmail.com", "Tran Thi Tan", "0395761111" },
                    { 7, "What will I get during my studies? ", "thaidra@gmail.com", "Nguyen Van Thai", "0956137222" },
                    { 8, "Can I take other experiential sessions outside the main school hours?", "Vanot@gmail.com", "Nguyen Hoai Van", "0986176333" },
                    { 9, "Can I make a reservation if I miss a midterm?", "thoklc@gmail.com", "Pham Tuyet Tho", "0296753144" },
                    { 10, "Can I leave the course for the next semester too?", "haibeo8@gmail.com", "Le Quang Hai", "0364781055" }
                });

            migrationBuilder.UpdateData(
                table: "RegistrationTests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseName",
                value: "Advance Python");

            migrationBuilder.UpdateData(
                table: "RegistrationTests",
                keyColumn: "Id",
                keyValue: 4,
                column: "CourseName",
                value: "Advance JavaScript");

            migrationBuilder.InsertData(
                table: "RegistrationTests",
                columns: new[] { "Id", "CourseName", "CustomerId", "RegistrationFee" },
                values: new object[,]
                {
                    { 6, "Basic Java", 6, 100m },
                    { 7, "Advance Python", 7, 100m },
                    { 8, "Basic SQL", 8, 100m },
                    { 9, "Advance JavaScript", 9, 100m },
                    { 10, "Basic Network Security", 10, 100m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassStudies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RegistrationTests",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RegistrationTests",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RegistrationTests",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RegistrationTests",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RegistrationTests",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Courses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ClassStudies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Bacic Network Security");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "UrlImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "UrlImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseName", "Fee", "TrainingTime", "UrlImage" },
                values: new object[] { " Basic SQL", 4275m, 4, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "UrlImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "CourseName", "UrlImage", "level" },
                values: new object[] { "Security", "Basic Network Security", null, 0 });

            migrationBuilder.UpdateData(
                table: "RegistrationTests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseName",
                value: "Basic Python");

            migrationBuilder.UpdateData(
                table: "RegistrationTests",
                keyColumn: "Id",
                keyValue: 4,
                column: "CourseName",
                value: "Basic JavaScript");
        }
    }
}
