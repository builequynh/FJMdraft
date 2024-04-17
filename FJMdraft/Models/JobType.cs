using System.ComponentModel.DataAnnotations;

namespace FJMdraft.Models
{
    public class JobType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
