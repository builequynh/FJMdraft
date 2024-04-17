using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FJMdraft.OriModels
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
       
        public int EmployerId { get; set; }
        [ForeignKey("EmployerId")]
        public User Employer { get; set; }

        public int categoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Reponsibility { get; set; }
        public string Experience { get; set; }
        public string AdditonalDetail { get; set; }
       
       
    }
}
