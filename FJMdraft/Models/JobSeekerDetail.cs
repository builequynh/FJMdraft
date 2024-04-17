using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FJMdraft.Models
{
    public class JobSeekerDetail
    {
        [Key]
        public int Id { get; set; }
        public string JobSeekerId { get; set; } //FK
        [ForeignKey("JobSeekerId")]
        public ApplicationUser JobSeeker { get; set; } //Cho CT biết là FK của model nào
        public string? Gender { get; set; } 
        public DateOnly? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? AboutMe { get; set; }
    }
}
