using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class Course//-> By Convention
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? TopicId { get; set; }

        public Topic Topic { get; set; }    
        public List<StudentCourse> StudentCourses { get; set; }
        public List<Course_Inst> CourseInstructors { get; set; }


    }
}
