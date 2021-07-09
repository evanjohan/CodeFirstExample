using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstExample.Migrations
{
    public partial class ChangeLengthEMployeeRollback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeNo",
                table: "Employee",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeNo",
                table: "Employee",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");
        }
    }
}
