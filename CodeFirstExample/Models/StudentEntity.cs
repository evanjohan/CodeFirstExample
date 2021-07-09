using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstExample.Models
{
    public class StudentEntity:AuditableDbEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<CoursesEntity> Courses { get; set; }

        public StudentEntity()
        {
            Courses = new HashSet<CoursesEntity>();
        }
    }
}
