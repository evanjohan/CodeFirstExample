using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstExample.Migrations
{
    public partial class ChangeLengthEMployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeNo",
                table: "Employee",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeNo",
                table: "Employee",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");
        }
    }
}
