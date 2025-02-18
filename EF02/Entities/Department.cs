using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    [Table("Departments")]
    internal class Department  //-> Data Annotation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Name { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime HiringDate { get; set; }

        public int? InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public List<Student> Students { get; set; }

    }
}
