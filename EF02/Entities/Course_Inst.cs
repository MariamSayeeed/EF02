using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class Course_Inst
    {
        public int? InstId { get; set; }
        public Instructor Instructor { get; set; }
        public int? CrId { get; set; }
        public Course Course { get; set; }
        public double Evaluate {  get; set; } 



    }
}
