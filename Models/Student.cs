using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Models
{
    internal class Student
    {

        //by convention
        public int Id { get; set; }
        public required string FName { get; set; }
        public required string LName { get; set; }
        public  string? Adress { get; set; }
        public  int Age { get; set; }
        public required int Dep_ID { get; set; }
    }
}
