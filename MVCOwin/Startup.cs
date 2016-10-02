
// Microsoft.Owin.Security.Cookies - enables cookie based authentication.
// This class will be automatically located and initialized by the OWIN host
// Namespace: Microsoft.Owin.Builder
// Assembly:  Microsoft.Owin (in Microsoft.Owin.dll)

using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;
using System;
using Microsoft.AspNet.Identity.EntityFramework;
using MVCOwin.Models;

[assembly: OwinStartup(typeof(MVCOwin.App_Start.Startup))]


namespace MVCOwin.App_Start
{
    // initialize  OWIN component by creating Startup class 
    public class Startup
    {
        public static Func<UserManager<Models.AppUser>> UserManagerFactory { get; private set; }

        // Configuration method takes OWIN IAppBuilder as a parameter. 
        public void Configuration(IAppBuilder app)
        {
            // UseCookieAuthentication tells ASP.NET to use cookie based authentication
            // set 2 properties: 'AuthenticationType' & 'LoginPath'

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/auth/login")
            });

            UserManagerFactory = () =>
            {
                var usermanager = new UserManager<AppUser>(
                    new UserStore<AppUser>(new AppDbContext()));

                // allow alphanumeric characters in username
                usermanager.UserValidator = new UserValidator<AppUser>(usermanager)
                {
                    AllowOnlyAlphanumericUserNames = false
                };

                usermanager.ClaimsIdentityFactory = new AppUserClaimsIdentityFactory();

                return usermanager;
            };
        }
    }
}
