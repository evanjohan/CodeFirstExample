using CodeFirstExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstExample.Configurations
{
    public abstract class ConfigurationBase<TEntity>:IEntityTypeConfiguration<TEntity> where TEntity :AuditableDbEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(b => b.CreatedBy).HasColumnType("varchar(50)").IsRequired();
            builder.Property(b => b.CreatedTime).HasColumnType("datetime").IsRequired();
            builder.Property(b => b.LastModifiedBy).HasColumnType("varchar(50)");
            builder.Property(b => b.LastModifiedTime).HasColumnType("datetime");
            builder.Property(b => b.TimeStatus).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate().IsRequired();
            builder.Property(b => b.RowStatus).IsRequired();
        }
    }
}
