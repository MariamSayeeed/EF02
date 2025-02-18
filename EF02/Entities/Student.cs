using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class Student  // Class Configuration
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public int DeptId { get; set; }
        public Department Department { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }
    }
}
