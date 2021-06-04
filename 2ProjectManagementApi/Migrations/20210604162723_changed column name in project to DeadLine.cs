using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _2ProjectManagementApi.Migrations
{
    public partial class changedcolumnnameinprojecttoDeadLine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Project");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeadLine",
                table: "Project",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeadLine",
                table: "Project");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
