using System.ComponentModel.DataAnnotations;

namespace FJMdraft.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
