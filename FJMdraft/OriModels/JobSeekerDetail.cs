using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace FJMdraft.OriModels
{
    public class JobSeekerDetail
    {
        [Key]
        public int Id { get; set; }
        
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User JobSeeker { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string? Avatar { get; set; }
        public string? Address { get; set; }
        public string? AboutMe { get; set; }
    }
}
