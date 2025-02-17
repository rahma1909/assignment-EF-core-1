using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Models
{
    internal class Department
    {
        //Data Annotations
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required]
        [StringLength(50,MinimumLength =10)]
        [Column(TypeName ="varchar")]
        public required string Name { get; set; }

        [DataType(DataType.Date)]
        public DateOnly HiringDate { get; set; }


        public required int Ins_ID { get; set; }
    }
}
