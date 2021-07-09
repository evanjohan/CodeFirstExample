using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeFirstExample.Models
{
    public abstract class AuditableDbEntity 
    {
        public int ID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public short RowStatus { get; set; }
        
        [Timestamp]
        public byte[] TimeStatus { get; set; }
    
    }
}
