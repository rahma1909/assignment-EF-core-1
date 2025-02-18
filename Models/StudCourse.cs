using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Models
{
    internal class StudCourse
    {
        [Column("StudentGrade")]
        public int Grade { get; set; }
        [Key]
        public int Course_ID { get; set; }
        [Key]
        public int Stud_ID { get; set; }
    }
}
