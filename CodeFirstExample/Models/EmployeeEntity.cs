using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstExample.Models
{
    public class EmployeeEntity :AuditableDbEntity
    {
        public string EmployeeNo { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public int DepartmentID { get; set;}
        public virtual DepartmentEntity Department { get; set; }
    }
}
