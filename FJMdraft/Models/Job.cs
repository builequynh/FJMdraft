using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FJMdraft.Utility.Helpers;

namespace FJMdraft.Models
{
    public class Job
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")] //Yêu cầu user nhập. Nếu null --> báo lỗi và yêu cầu nhập lại
        public string Title { get; set; }

        [Required(ErrorMessage = "Address is required")] //Yêu cầu user nhập. Nếu null --> báo lỗi và yêu cầu nhập lại
        public string Address { get; set; }
        public string? Description { get; set; }
        public string? Responsibility { get; set; }
        public string? Experience { get; set; }
        public string? AdditionalDetail { get; set; }
        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "Deadline is required")] //Yêu cầu user nhập. Nếu null --> báo lỗi và yêu cầu nhập lại
        [GreaterThanToday(ErrorMessage = "The deadline must be greater than today's date")] /*Check xem deadline user thêm đã qua chưa.
                                                                                             Nếu đã qua --> báo lỗi và yêu cầu nhập lại*/
        public DateOnly Deadline { get; set; }

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")] //tạo FK
        public Category? Category { get; set; } //giúp chương trình biết là FK từ model nào

        public string? EmployerId { get; set; }
        [ForeignKey("EmployerId")] //tạo FK
        public ApplicationUser? Employer { get; set; } //giúp chương trình biết là FK từ model nào

        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId")] //tạo FK
        public Company? Company { get; set; } //giúp chương trình biết là FK từ model nào

        [Required(ErrorMessage = "Job Type is required")] //Yêu cầu user nhập. Nếu null --> báo lỗi và yêu cầu nhập lại
        public int JobTypeId { get; set; }
        [ForeignKey("JobTypeId")] //tạo FK
        public JobType? JobType { get; set; } //giúp chương trình biết là FK từ model nào
    }
}
