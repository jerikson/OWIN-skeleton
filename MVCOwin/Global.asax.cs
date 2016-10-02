using MVCOwin.App_Start;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCOwin
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            // Add the Filter to the Global.asax from App_Start
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
