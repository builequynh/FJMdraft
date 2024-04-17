using System.ComponentModel.DataAnnotations;
using System;

namespace FJMdraft.OriModels
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAprroved { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
