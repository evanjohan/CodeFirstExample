using CodeFirstExample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstExample.Facade
{
    public class StudentFacade
    {
        public StudentFacade()
        {

        }

        public void AddStudent(StudentEntity studentEntity)
        {
            using (var context = new OfficeContext())
            {
                context.Add(studentEntity);
                context.SaveChanges();
            }
            Console.WriteLine("Success");
        }

        public List<StudentEntity> ShowStudent()
        {
            List<StudentEntity> result = new List<StudentEntity>();
            using (var context = new OfficeContext())
            {
                result = context.Students.Include(c => c.Courses).ToList();
            }

            return result;

        }
    }
}
