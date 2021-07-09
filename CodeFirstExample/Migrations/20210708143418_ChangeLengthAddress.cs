using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstExample.Migrations
{
    public partial class ChangeLengthAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeAddress",
                table: "Employee",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeAddress",
                table: "Employee",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");
        }
    }
}
