using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Models
{
    internal class course
    {

        //fluent api && class configrations

        public int Id { get; set; }
        public DateTime Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("Topics")]
        public int Topic_Id { get; set; }

        public Topic? Topics { get; set; }
        public List<StudCourse> students { get; set; }

        public List<CourseInstructor> Instructors { get; set; }


    }
}
