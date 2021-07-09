using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstExample.Models
{
    public class DepartmentEntity: AuditableDbEntity
    {
        public String DepartmentNo { get; set; }
        public string DepartmentName { get; set; }
    }
}
