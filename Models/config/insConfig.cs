using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace assignment.Models.config
{
    internal class insConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> I)
        {
            I.HasKey(c => c.Id);


            I.Property(c => c.Name).IsRequired()
                .HasMaxLength(50)
                 .HasColumnName("InstructorName")
                .HasColumnType("varchar");

            I.Property(c => c.address)
                .HasMaxLength(200)
                 .HasColumnType("varchar");

            I.Property(c => c.bouns)
                .IsRequired(false);

            I.Property(c => c.salary)
            .IsRequired();

            I.Property(c => c.HourRate)
            .IsRequired(false);

       
           
        }
    }
}
