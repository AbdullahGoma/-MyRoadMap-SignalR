using Microsoft.AspNetCore.Identity;

namespace ChatApp.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Messages = new HashSet<Message>();
        }
        // AppUser have relation one to many with Message
        public virtual ICollection<Message> Messages { get; set; }
    }
}
