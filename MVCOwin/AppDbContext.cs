using Microsoft.AspNet.Identity.EntityFramework;
using MVCOwin.Models;
using System.Data.Entity;

namespace MVCOwin
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext()
            : base("MVCOwin")
        {
        }
    }
}