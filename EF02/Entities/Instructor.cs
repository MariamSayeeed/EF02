using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class Instructor   // --> Fluent API
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Bouns { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }
        //----------------
        public int? DeptID { get; set; }
        public Department Department { get; set; }
        public List<Course_Inst> CourseInstructors { get; set; }
    }

}
