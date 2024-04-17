using FJMdraft.OriModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FJMdraft.Models
{
    public class ApplicantCV
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateSubmitted { get; set; }
        public DateTime? DateResponded {get; set;} //? => chưa chắc được reply
        public string? ResponseMessage { get; set; } //? => tương tự trên

        [Required(ErrorMessage = "File is required")] /*Yêu cầu user cung cấp CV
                                                       * User ko cung cấp -> báo lỗi*/
        public string FileCV { get; set; }

        public string JobSeekerId { get; set; }
        [ForeignKey("JobSeekerId")] //khóa ngoại
        public ApplicationUser JobSeeker { get; set; }  //giúp CT biết là khóa ngoại từ model nào

        public string? CVStatus { get; set; } //có thể trống. chưa rõ nguyên do vì sao?

        public int JobId { get; set; }
        [ForeignKey("JobId")] //tương tự trên
        public Job Job { get; set; } //tương tự trên
    }
}
