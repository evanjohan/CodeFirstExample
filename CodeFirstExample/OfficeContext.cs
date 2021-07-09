using CodeFirstExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CodeFirstExample
{
    public class OfficeContext: DbContext
    {
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<DepartmentEntity> Departments { get; set; }
        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<CoursesEntity> Coursess { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json")
                        .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("OfficeDB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(typeof(OfficeContext).Assembly);

       
    }
}
