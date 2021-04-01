using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SymphonyWebApp.Migrations
{
    public partial class createTea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 3,
                column: "UrlImage",
                value: "sagar.png");

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "Address", "Dob", "FirstName", "Gmail", "LastName", "Major", "UrlImage" },
                values: new object[,]
                {
                    { 6, "BTM 2nd Stage, Bengaluru, Karnataka, India", new DateTime(1994, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arvind", "Arvind@gmail.com", "Carpenter", "JAVA ,SQL, Mongo DB, VueJS", "arvind.jpg" },
                    { 7, "Vaniyambadi, Tamil Nadu, India", new DateTime(1991, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ks Sri", "Nandhish@gmail.com", "Nandhish", "Java, Python", "ks.jpg" },
                    { 8, "Dwarka, New Delhi, Delhi, India", new DateTime(1989, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aakash", "Madan@gmail.com", "Madan", "Java Programming,Java Data Structures, Data Science", "aakash.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 3,
                column: "UrlImage",
                value: "sagar.jpg");
        }
    }
}
