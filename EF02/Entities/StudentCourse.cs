using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class StudentCourse
    {
        public int? StdId { get; set; }
        public Student Student { get; set; }
        public int? CrId { get; set; }
        public Course Course { get; set; }
        public double Grade { get; set; }


    }
}
