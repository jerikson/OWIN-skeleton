using MVCOwin;
using System.Security.Claims;
using System.Web.Mvc;

namespace MVCOwin.Controllers
{
    public abstract class AppController : Controller
    {
        public AppUserPrincipal CurrentUser
        {
            get
            {
                return new AppUserPrincipal(base.User as ClaimsPrincipal);
            }
        }
    }
}
