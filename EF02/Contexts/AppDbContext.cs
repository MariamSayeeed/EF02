using EF02.Configurations;
using EF02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Contexts
{
    internal class AppDbContext :DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Instructor Class -> Fluent API
            modelBuilder.Entity<Instructor>().HasKey(I => I.Id);
            modelBuilder.Entity<Instructor>().Property(I => I.Name).HasMaxLength(50);
            modelBuilder.Entity<Instructor>().Property(I => I.Salary).HasDefaultValue(10000);

            //--------------------
            // Student Class -> Class Configuration
            modelBuilder.ApplyConfiguration(new StudentConfig());
            //------------


            modelBuilder.Entity<StudentCourse>()
            .HasKey(sc => new { sc.StdId, sc.CrId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StdId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CrId);


            modelBuilder.Entity<Course_Inst>()
           .HasKey(ci => new { ci.InstId, ci.CrId });

            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.CourseInstructors)
                .HasForeignKey(ci => ci.InstId);

            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.CourseInstructors)
                .HasForeignKey(ci => ci.CrId);


            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MARIAM\\SQLSERVER2022; Database= EF02; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> studentCourses { get; set; }
        public DbSet<Topic> Topics { get; set; }

    }
}
