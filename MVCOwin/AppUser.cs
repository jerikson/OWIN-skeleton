using Microsoft.AspNet.Identity.EntityFramework;

namespace MVCOwin.Models
{
    public class AppUser : IdentityUser
    {
        public string Country { get; set; }
        public int Age { get; set; }
    }
}