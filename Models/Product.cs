using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnCRUD.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }

        [ForeignKey("Categories")]
        public int CategoryId { get; set; }
        //add Category table
        public virtual Category Categories { get; set; }
         

    }
}
