using Microsoft.EntityFrameworkCore.Migrations;

namespace SymphonyWebApp.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassStudyCourse_ClassStudies_ClassStudiesClassId",
                table: "ClassStudyCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassStudyCourse_Courses_CoursesCourseId",
                table: "ClassStudyCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_ClassStudies_ClassId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CourseId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassStudyCourse",
                table: "ClassStudyCourse");

            migrationBuilder.DropIndex(
                name: "IX_ClassStudyCourse_CoursesCourseId",
                table: "ClassStudyCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassStudies",
                table: "ClassStudies");

            migrationBuilder.DropColumn(
                name: "ClassStudiesClassId",
                table: "ClassStudyCourse");

            migrationBuilder.DropColumn(
                name: "CoursesCourseId",
                table: "ClassStudyCourse");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Students",
                type: "int",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Students",
                type: "int",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AddColumn<int>(
                name: "ClassStudiesId",
                table: "ClassStudyCourse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CoursesId",
                table: "ClassStudyCourse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassStudyCourse",
                table: "ClassStudyCourse",
                columns: new[] { "ClassStudiesId", "CoursesId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassStudies",
                table: "ClassStudies",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ClassStudyCourse_CoursesId",
                table: "ClassStudyCourse",
                column: "CoursesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStudyCourse_ClassStudies_ClassStudiesId",
                table: "ClassStudyCourse",
                column: "ClassStudiesId",
                principalTable: "ClassStudies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStudyCourse_Courses_CoursesId",
                table: "ClassStudyCourse",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ClassStudies_ClassId",
                table: "Students",
                column: "ClassId",
                principalTable: "ClassStudies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CourseId",
                table: "Students",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassStudyCourse_ClassStudies_ClassStudiesId",
                table: "ClassStudyCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassStudyCourse_Courses_CoursesId",
                table: "ClassStudyCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_ClassStudies_ClassId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CourseId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassStudyCourse",
                table: "ClassStudyCourse");

            migrationBuilder.DropIndex(
                name: "IX_ClassStudyCourse_CoursesId",
                table: "ClassStudyCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassStudies",
                table: "ClassStudies");

            migrationBuilder.DropColumn(
                name: "ClassStudiesId",
                table: "ClassStudyCourse");

            migrationBuilder.DropColumn(
                name: "CoursesId",
                table: "ClassStudyCourse");

            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "Students",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "ClassId",
                table: "Students",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AddColumn<string>(
                name: "ClassStudiesClassId",
                table: "ClassStudyCourse",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CoursesCourseId",
                table: "ClassStudyCourse",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "RollNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassStudyCourse",
                table: "ClassStudyCourse",
                columns: new[] { "ClassStudiesClassId", "CoursesCourseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassStudies",
                table: "ClassStudies",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassStudyCourse_CoursesCourseId",
                table: "ClassStudyCourse",
                column: "CoursesCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStudyCourse_ClassStudies_ClassStudiesClassId",
                table: "ClassStudyCourse",
                column: "ClassStudiesClassId",
                principalTable: "ClassStudies",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStudyCourse_Courses_CoursesCourseId",
                table: "ClassStudyCourse",
                column: "CoursesCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ClassStudies_ClassId",
                table: "Students",
                column: "ClassId",
                principalTable: "ClassStudies",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CourseId",
                table: "Students",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
