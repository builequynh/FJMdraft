using System.ComponentModel.DataAnnotations;

namespace FJMdraft.Models
{
    public class City //cho company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
