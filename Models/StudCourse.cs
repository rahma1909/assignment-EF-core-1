using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace assignment.Models
{
    //[PrimaryKey(nameof(Course_ID),nameof(Stud_ID))]
    internal class StudCourse
    {
        [Column("StudentGrade")]
        public int Grade { get; set; }
   
        public int course_Id { get; set; }
   
        public int Student_Id { get; set; }
    }
}
