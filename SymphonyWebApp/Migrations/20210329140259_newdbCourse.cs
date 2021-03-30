using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SymphonyWebApp.Migrations
{
    public partial class newdbCourse : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
