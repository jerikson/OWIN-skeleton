using System.Web.Mvc;
using System.Net;
using System.Net.Sockets;
using System;

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



        public static string GetLocalIP() {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList) {
                if (ip.AddressFamily == AddressFamily.InterNetwork)  {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP not e found");
        }


    }


}