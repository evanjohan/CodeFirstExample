using CodeFirstExample.Facade;
using CodeFirstExample.Models;
using System;
using System.Collections.Generic;

namespace CodeFirstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsStart = true;
            while (IsStart)
            {


                Console.WriteLine("===------------- MENU ---------------===");
                Console.WriteLine("1. Add Employee  ");
                Console.WriteLine("2. Show Employee ");
                Console.WriteLine("3. Add Student ");
                Console.WriteLine("4. Show Student ");
                Console.Write("Inputan data:  "); int data = int.Parse(Console.ReadLine());
                EmployeeFacade facade = new EmployeeFacade();
                StudentFacade studentFacade = new StudentFacade();

                switch (data)
                {
                    case 1:
                        Console.WriteLine("============= Add Employee ===============");
                        EmployeeEntity employee = new EmployeeEntity
                        {
                            EmployeeAddress = "jlan puri",
                            EmployeeName = "Zuma",
                            EmployeeNo = "002AD2938",
                            DepartmentID = 2,
                            CreatedBy = "SYSTEM",
                            CreatedTime = DateTime.Now,
                            RowStatus = 0
                        };
                        facade.AddEmployee(employee);
                        break;
                    case 2:
                        Console.WriteLine("============= Show Employee ===============");
                        List<EmployeeEntity> result = new List<EmployeeEntity>();
                        result = facade.ShowEmployee();
                        Console.WriteLine("");
                        Console.WriteLine("Data :");
                        Console.WriteLine("----------------------------------------------------------");
                        foreach (var item in result)
                        {
                            Console.WriteLine("EmployeeNo       : " + item.EmployeeNo);
                            Console.WriteLine("EmployeeName     : " + item.EmployeeName);
                            Console.WriteLine("EmployeeAddress  : " + item.EmployeeAddress);
                            Console.WriteLine("DepartmentNo     : " + item.Department.DepartmentNo);
                            Console.WriteLine("DepartmentName   : " + item.Department.DepartmentName);
                            Console.WriteLine("----------------------------------------------------------");
                        }
                        break;
                    case 3:
                        Console.WriteLine("============= Add Student ===============");
                        StudentEntity student = new StudentEntity
                        {
                            FirstName = "Darin",
                            LastName = "Long",
                            CreatedBy = "SYSTEM",
                            CreatedTime = DateTime.Now,
                            RowStatus = 0,
                            Courses = new List<CoursesEntity>
                        {
                            new CoursesEntity{
                                Title="rich",
                                CreatedBy = "SYSTEM",
                                CreatedTime = DateTime.Now,
                                RowStatus = 0},
                            new CoursesEntity{
                                Title="poor",
                                CreatedBy = "SYSTEM",
                                CreatedTime = DateTime.Now,
                                RowStatus = 0},
                            new CoursesEntity{
                                Title="richpoor",
                                CreatedBy = "SYSTEM",
                                CreatedTime = DateTime.Now,
                                RowStatus = 0},
                        }
                        };
                        studentFacade.AddStudent(student);
                        break;
                    case 4:
                        Console.WriteLine("============= Show Student ===============");
                        List<StudentEntity> studentresult = new List<StudentEntity>();
                        studentresult = studentFacade.ShowStudent();
                        Console.WriteLine("");
                        Console.WriteLine("Data :");
                        Console.WriteLine("----------------------------------------------------------");
                        foreach (var item in studentresult)
                        {
                            Console.WriteLine("FirstName   : " + item.FirstName);
                            Console.WriteLine("LasName     : " + item.LastName);
                            Console.WriteLine("+------------------------------------------+");
                            Console.WriteLine("Title       : ");
                            foreach (var detail in item.Courses)
                            {
                                Console.WriteLine("             - " + detail.Title);
                            }
                            Console.WriteLine("+------------------------------------------+");
                        }
                        break;

                    default :
                        IsStart = false;
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
