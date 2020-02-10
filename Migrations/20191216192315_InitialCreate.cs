using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM3.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyDetails",
                columns: table => new
                {
                    CompanyName = table.Column<string>(nullable: false),
                    PublicEmail = table.Column<string>(nullable: true),
                    ContactPersonOne = table.Column<string>(nullable: true),
                    PersonalEmailOne = table.Column<string>(nullable: true),
                    ContactPersonTwo = table.Column<string>(nullable: true),
                    PersonalEmailTwo = table.Column<string>(nullable: true),
                    FirstContactDate = table.Column<DateTime>(nullable: false),
                    SecondContactDate = table.Column<DateTime>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    AccountManager = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyDetails", x => x.CompanyName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyDetails");
        }
    }
}
