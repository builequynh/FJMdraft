using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace FJMdraft.OriModels
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
       
        public int EmployerId { get; set; }
        [ForeignKey("employerId")]
        public User User { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Address { get; set; }
        public int Size { get; set; }
        public string? Logo { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

