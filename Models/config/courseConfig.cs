using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace assignment.Models.config
{
    internal class courseConfig : IEntityTypeConfiguration<course>
    {
        public void Configure(EntityTypeBuilder<course> c)
        {
            c.HasKey(c => c.Id);
            

            c.Property(c => c.Name).IsRequired()
                .HasMaxLength(50)
                 .HasColumnName("CourseName")
                .HasColumnType("varchar");

            c.Property(c => c.Description)
                .HasMaxLength(200)
                 .HasColumnType("varchar");

            c.Property(c => c.Duration)
                .HasDefaultValueSql("GETDATE()");

           
        }
    }
}
