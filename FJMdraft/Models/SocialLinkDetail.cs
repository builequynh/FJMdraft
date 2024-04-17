using System.ComponentModel.DataAnnotations.Schema;

namespace FJMdraft.Models
{
    internal class SocialLinkDetail
    {
        public int Id { get; set; }

        public int ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }

        public int SocialLinkId { get; set; }
        [ForeignKey("SocialLinkId")]
        public SocialLink SocialLink { get; set; }

        public string url { get; set; }
    }
}
