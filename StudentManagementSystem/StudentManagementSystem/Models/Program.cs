using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class ProgramOfStudy
    {
        [Key]
        public string ProgramCode { get; set; }

        [Required]
        public string ProgramName { get; set; }
    }
}
