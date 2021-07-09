using CodeFirstExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstExample.Configurations
{
    public class StudentEntityConfiguration : ConfigurationBase<StudentEntity>
    {
        public override void Configure(EntityTypeBuilder<StudentEntity> builder)
        {
            base.Configure(builder);
            builder.ToTable("Student");
            builder.HasKey(b => b.ID);
            builder.Property(b => b.FirstName).HasColumnType("varchar(50)").IsRequired();
            builder.Property(b => b.LastName).HasColumnType("varchar(50)").IsRequired();

            builder.HasMany(b => b.Courses)
                   .WithOne()
                   .HasForeignKey(b => b.StudentID)
                   .IsRequired();
        }
    }
}
