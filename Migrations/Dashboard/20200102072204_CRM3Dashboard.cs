using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM3.Migrations.Dashboard
{
    public partial class CRM3Dashboard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskName = table.Column<string>(nullable: false),
                    Deadline = table.Column<DateTime>(nullable: false),
                    Important = table.Column<bool>(nullable: false),
                    HighComplexity = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
