using EF02.Contexts;
using EF02.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                // C -> Create
                var student = new Student
                {
                    FName = "Mariam",
                    LName = "Sayed",
                    Address = "Fayoum",
                    Age = 22,
                    DeptId = 1
                };

                var course = new Course
                {
                    Name = "EFCore",
                    Description = "EntityFrameworkCore",
                    Duration = 60
                };

                var studentCourse = new StudentCourse
                {
                    StdId = student.Id,
                    CrId = course.Id,
                    Grade = 95.0
                };

                context.studentCourses.Add(studentCourse);
                context.SaveChanges();

                // R -> Read  
                var studentCourses = context.studentCourses.Select(sc => new
                {
                    sc.StdId,
                    sc.CrId,
                    sc.Grade
                }).ToList();

                foreach (var sc in studentCourses)
                {
                    Console.WriteLine($"Student ID: {sc.StdId}, Course ID: {sc.CrId}, Grade: {sc.Grade}");
                }

                // U -> Update 
                var studentCourseToUpdate = context.studentCourses.FirstOrDefault(sc => sc.StdId == 1 && sc.CrId == 1);
                if (studentCourseToUpdate != null)
                {
                    studentCourseToUpdate.Grade = 98.5;
                    context.SaveChanges();
                }

                // D -> Delete 
                var studentCourseToDelete = context.studentCourses.FirstOrDefault(sc => sc.StdId == 1 && sc.CrId == 1);
                if (studentCourseToDelete != null)
                {
                    context.studentCourses.Remove(studentCourseToDelete);
                    context.SaveChanges();
                }
            }
        }
      }
}