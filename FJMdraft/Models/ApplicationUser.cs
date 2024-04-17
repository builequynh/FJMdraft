using Microsoft.AspNetCore.Identity;

namespace FJMdraft.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual string FullNamme { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual int StatusId { get; set; }
    }
}
