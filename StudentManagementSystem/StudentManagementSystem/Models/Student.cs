using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Range(0.0, 4.0)]
        public double GPA { get; set; }

        // Program Name instead of Program Code, no foreign key
        [Required]
        public string ProgramName { get; set; }  // Program name (e.g., "Computer Programmer", "BACS")

        // Computed Property for Age
        [NotMapped]
        public int Age => DateTime.Now.Year - DateOfBirth.Year;

        // Computed Property for GPA Scale
        [NotMapped]
        public string GPAScale
        {
            get
            {
                if (GPA >= 3.5) return "Excellent";
                if (GPA >= 3.0) return "Very Good";
                if (GPA >= 2.5) return "Good";
                if (GPA >= 2.0) return "Satisfactory";
                return "Unsatisfactory";
            }
        }
    }
}
