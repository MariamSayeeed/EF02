using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        //public List<Student> students { get; set; }
        //public List<Course> courses { get; set; }
        public double Grade { get; set; }

        // public List<StudentCourse> Courses { get; set; }

    }

}
