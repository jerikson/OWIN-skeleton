using System.Web.Mvc;
using System.Net;

namespace MVCOwin.Controllers
{
    /*
        [AllowAnonymous]
        Guest users gets redirected to /Auth/Index on browsing /Home/Index
    */

    public class HomeController : AppController
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Data()
        {
            return View();
        }



    }


}