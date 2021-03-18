using Microsoft.EntityFrameworkCore.Migrations;

namespace SymphonyWebApp.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "Students",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldUnicode: false,
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "ClassId",
                table: "Students",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldUnicode: false,
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "RollNumber",
                table: "Students",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldUnicode: false,
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "Courses",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldUnicode: false,
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "CoursesCourseId",
                table: "ClassStudyCourse",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)");

            migrationBuilder.AlterColumn<string>(
                name: "ClassStudiesClassId",
                table: "ClassStudyCourse",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)");

            migrationBuilder.AlterColumn<string>(
                name: "ClassId",
                table: "ClassStudies",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldUnicode: false,
                oldMaxLength: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "Students",
                type: "varchar(5)",
                unicode: false,
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "ClassId",
                table: "Students",
                type: "varchar(5)",
                unicode: false,
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "RollNumber",
                table: "Students",
                type: "varchar(5)",
                unicode: false,
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "Courses",
                type: "varchar(5)",
                unicode: false,
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "CoursesCourseId",
                table: "ClassStudyCourse",
                type: "varchar(5)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "ClassStudiesClassId",
                table: "ClassStudyCourse",
                type: "varchar(5)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "ClassId",
                table: "ClassStudies",
                type: "varchar(5)",
                unicode: false,
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);
        }
    }
}
