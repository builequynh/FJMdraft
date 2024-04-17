using System.ComponentModel.DataAnnotations;

namespace FJMdraft.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
