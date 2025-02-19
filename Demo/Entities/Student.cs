using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public List<StudentCourse> Courses { get; set; }

    }
}
