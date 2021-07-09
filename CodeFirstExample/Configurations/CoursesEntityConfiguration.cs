using CodeFirstExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstExample.Configurations
{
    public class CoursesEntityConfiguration : ConfigurationBase<CoursesEntity>
    {
        public override void Configure(EntityTypeBuilder<CoursesEntity> builder)
        {
            base.Configure(builder);
            builder.ToTable("Courses");
            builder.HasKey(b => b.ID);
            builder.Property(b => b.Title).HasColumnType("varchar(100)").IsRequired();
            builder.Property(b => b.StudentID).IsRequired();
        }
    }
}
