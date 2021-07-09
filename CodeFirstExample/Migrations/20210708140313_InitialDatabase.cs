using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstExample.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentNo = table.Column<string>(type: "varchar(20)", nullable: false),
                    DepartmentName = table.Column<string>(type: "varchar(50)", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(50)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    LastModifiedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false),
                    TimeStatus = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", nullable: false),
                    EmployeeName = table.Column<string>(type: "varchar(50)", nullable: false),
                    EmployeeAddress = table.Column<string>(type: "varchar(100)", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(50)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    LastModifiedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false),
                    TimeStatus = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentID",
                table: "Employee",
                column: "DepartmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
