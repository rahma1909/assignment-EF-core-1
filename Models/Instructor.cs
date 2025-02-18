using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Models
{
    internal class Instructor
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        public double? bouns { get; set; }
        public double salary { get; set; }
        public int dep_id { get; set; }
        public double? HourRate{ get; set; }
    }
}
