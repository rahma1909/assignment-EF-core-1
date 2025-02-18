using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment.Models;
using assignment.Models.config;
using Microsoft.EntityFrameworkCore;

namespace assignment.Data
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new courseConfig());
            modelBuilder.ApplyConfiguration(new insConfig());
        }
        public ITIDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=ITI; Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<course> courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CourseInstructor> CourseInstructor { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<StudCourse> StudentCourse { get; set; }
    }
}
