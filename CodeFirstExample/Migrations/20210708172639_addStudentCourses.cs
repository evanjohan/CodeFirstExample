using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstExample.Migrations
{
    public partial class addStudentCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(50)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    LastModifiedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false),
                    TimeStatus = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(100)", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(50)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    LastModifiedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false),
                    TimeStatus = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Courses_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentID",
                table: "Courses",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
