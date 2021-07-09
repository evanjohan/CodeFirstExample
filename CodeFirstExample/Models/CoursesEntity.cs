using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstExample.Models
{
    public class CoursesEntity:AuditableDbEntity
    {
        public string Title { get; set; }
        public int StudentID { get; set; }
    }
}
