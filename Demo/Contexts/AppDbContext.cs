using Demo.Configurations;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Contexts
{
    internal class AppDbContext: DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Employee>().HasKey("Id");
            // modelBuilder.Entity<Employee>().HasKey(E => E.Id);
            //  modelBuilder.Entity<Employee>().HasKey(nameof(Employee.Id));

            //modelBuilder.Entity<Employee>().HasKey(E => E.Id);
            //modelBuilder.Entity<Employee>().Property(E => E.Id).UseIdentityColumn(10,10);
            //modelBuilder.Entity<Employee>().Property(E => E.Name)
            //                               .HasColumnName("EmployeeName")
            //                               .HasColumnType("varchar")
            //                               .HasMaxLength(50)
            //                               .IsRequired();

            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.Entity<Employee>()
            //            .HasOne(E => E.Department)
            //            .WithOne(D => D.Manager)
            //            .HasForeignKey<Department>(D => D.EmpId);

            modelBuilder.Entity<Department>()
                        .HasOne(E => E.Manager)
                        .WithOne(D => D.Department)
                        .HasForeignKey<Department>(D => D.EmpId);

            modelBuilder.Entity<Department>()
                        .HasMany(D => D.Employee)
                        .WithOne(E => E.WorkFor)
                        .HasForeignKey(E => E.WorkForId);
            modelBuilder.Entity<StudentCourse>().HasKey(SC => new { SC.CourseId, SC.StudentId });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Code To Connect To DB  
            optionsBuilder.UseSqlServer("Server =MARIAM\\SQLSERVER2022 ; Database = DemoEF02 ; Trusted_Connection = True ; TrustServerCertificate = True");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Department { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    
    }
}
