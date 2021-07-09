using CodeFirstExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstExample.Configurations
{
    public class DepartmentEntityTypeConfiguration : ConfigurationBase<DepartmentEntity>
    {
        public override void Configure(EntityTypeBuilder<DepartmentEntity> builder)
        {
            base.Configure(builder);
            builder.ToTable("Department");
            builder.HasKey(b => b.ID);
            builder.Property(b => b.DepartmentNo).HasColumnType("varchar(20)").IsRequired();
            builder.Property(b => b.DepartmentName).HasColumnType("varchar(50)").IsRequired();
        }
    }
}
