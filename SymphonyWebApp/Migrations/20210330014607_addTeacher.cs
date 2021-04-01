using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SymphonyWebApp.Migrations
{
    public partial class addTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "Address", "Dob", "FirstName", "Gmail", "LastName", "Major", "UrlImage" },
                values: new object[,]
                {
                    { 1, "Andheri East, Mumbai, Maharashtra, India", new DateTime(1964, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miranda", "JudeMiranda@gmail.com", "Jude", "Python, Data Science", "jude.jpg" },
                    { 2, "Islamabad Expressway, I 8/4 I-8, Islamabad, Islamabad Capital Territory, Pakistan", new DateTime(1974, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nadeem", "Nadeem@gmail.com", "Mehmood", "JAVA, Mechanical Engineering", "nadeem.jpg" },
                    { 3, "Pune, Maharashtra, India", new DateTime(1984, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sagar", "Yadav@gmail.com", "Yadav", "JavaScript, Deep Learning, C++", "sagar.jpg" },
                    { 4, "Ameerpet, Hyderabad, Telangana, India", new DateTime(1978, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Surya", "Reddy@gmail.com", "Reddy", "Core JAVA, Angular 2,Spring MVC, SQL", "surya.jpg" },
                    { 5, "Abbottabad, Khyber Pakhtunkhwa, Pakistan", new DateTime(1984, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muhammad", "Ubaid@gmail.com", "Ubaid", "Java Programming,Java Data Structures, Data Science", "ubaid.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
