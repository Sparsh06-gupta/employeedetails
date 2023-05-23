using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserData.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    PkEmployeeId = table.Column<long>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Skills = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hobbies = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.PkEmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
