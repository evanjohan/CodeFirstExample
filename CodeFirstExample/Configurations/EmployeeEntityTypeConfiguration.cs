using CodeFirstExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstExample.Configurations
{
    public class EmployeeEntityTypeConfiguration: ConfigurationBase<EmployeeEntity>
    {
        public override void Configure(EntityTypeBuilder<EmployeeEntity> builder)
        {
            base.Configure(builder);
            builder.ToTable("Employee");
            builder.HasKey(b => b.ID);

            builder.Property(b => b.EmployeeNo).HasColumnType("varchar(20)").IsRequired();
            builder.Property(b => b.EmployeeName).HasColumnType("varchar(50)").IsRequired();
            builder.Property(b => b.EmployeeAddress).HasColumnType("varchar(100)").IsRequired();
            builder.Property(b => b.DepartmentID).IsRequired();


            builder.HasOne(b => b.Department)
                    .WithMany()
                    .HasForeignKey(c => c.DepartmentID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();
        }
    }
}
