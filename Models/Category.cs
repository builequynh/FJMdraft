﻿pusing System.ComponentModel.DataAnnotations;

namespace LearnCRUD.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
