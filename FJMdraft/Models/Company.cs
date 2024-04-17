using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FJMdraft.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? About { get; set; } //Cho phép company để trống about
        public string? Address { get; set; } //Cho phép trống địa chỉ
        public int? Size { get; set; } //Được giữ bí mật về quy mô công ty
        public string? Logo { get; set; } //Ko yêu cầu file logo
        public DateTime CreatedAt { get; set; }

        public int CityId { get; set; }
        [ForeignKey("CityId")] //tạo khóa ngoại
        public City City { get; set; } //cho CT biết sẽ lấy FK từ model nào
    }
}
