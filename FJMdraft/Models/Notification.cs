using System.ComponentModel.DataAnnotations.Schema;

namespace FJMdraft.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        public string? SenderId { get; set; }
        [ForeignKey("SenderId")]
        public ApplicationUser? Sender { get; set; }

        public string? ReceiverId { get; set; }
        [ForeignKey("ReceiverId")]
        public ApplicationUser? Receiver { get; set; }

        //Noti có thể ko có người gửi & nhận

    }
}
