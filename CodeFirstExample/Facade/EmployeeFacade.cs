using CodeFirstExample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstExample.Facade
{
    public class EmployeeFacade
    {
        public EmployeeFacade()
        {

        }

        public void AddEmployee(EmployeeEntity employeeEntity)
        {
            using (var context = new OfficeContext())
            {
                context.Add(employeeEntity);
                context.SaveChanges();
            }
            Console.WriteLine("Success");
        }

        public List<EmployeeEntity> ShowEmployee()
        {
            List<EmployeeEntity> result = new List<EmployeeEntity>();
            using (var context = new OfficeContext())
            {
                result = context.Employees.Include(c => c.Department).ToList();
            }

            return result;
            
        }
    }
}
