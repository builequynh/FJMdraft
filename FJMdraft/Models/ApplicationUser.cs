using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FJMdraft.OriModels;
using Microsoft.AspNetCore.Identity;

namespace FJMdraft.Models{
    public class ApplicationUser : IdentityUser { //kế thừa class IdentityUser
        [Required] //ko được bỏ trống trường này
        [Display(Name = "Full Name")] //Hiển thị label Name => Full Name khi Models -> View
        [Range(10, 1000, ErrorMessage = "You have to enter a correct name fully")] /*Báo lỗi và yêu
        cầu người ùng nhập đầy đủ họ tên trong range từ 10 - 1000 ký tự*/
        public string Name {get;set;}
        public DateTime CreatedAt {get;set;}
        public string? Avatar {get;set;} //avt user có thể trống
        public string AccountStatus {get;set;}
        public int? CompanyId {get;set;} /*Job Seeker có thể chưa có job 
        => companyId có thể trống*/
        [ForeignKey("CompanyId")] //tạo khóa ngoại
        public Company Company {get;set;} //giúp chương trình biết lấy khóa ngoại từ model nào


    }
}