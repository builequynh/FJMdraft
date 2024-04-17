using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FJMdraft.OriModels;



namespace FJMdraft.Models{
    public class Category {
        [Key]
        public int Id {get;set;}
        public string? Name {get;set;} //? = can be empty. Nhưng cho vào để đỡ ngứa mắt
        public bool IsAprroved {get;set;} //bool = true/false
        public DateTime CreatedAt {get;set;}
        public string? CreatedByUserId {get;set;} //? tương tự trên
        [ForeignKey("CreatedByUserId")] //tạo khóa ngoại
        public ApplicationUser? CreatedByUser {get;set;} //cho chương trình hiểu lấy khóa ngoại từ models nào

    }
}