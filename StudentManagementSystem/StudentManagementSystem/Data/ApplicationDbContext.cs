using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;
using System;

namespace StudentManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; } // No need for Programs DbSet anymore

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Students with ProgramName directly
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Bart",
                    LastName = "Simpson",
                    DateOfBirth = new DateTime(1971, 5, 31),
                    GPA = 2.7,
                    ProgramName = "Arts and Sciences" // Direct ProgramName, no ProgramCode or ProgramOfStudy
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Lisa",
                    LastName = "Simpson",
                    DateOfBirth = new DateTime(1973, 8, 5),
                    GPA = 4.0,
                    ProgramName = "Arts and Sciences" // Direct ProgramName, no ProgramCode or ProgramOfStudy
                }
            );
        }
    }
}
