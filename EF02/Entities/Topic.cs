using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class Topic  //-> Data Annotation
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public List<Course> Courses { get; set; }
    }
}
