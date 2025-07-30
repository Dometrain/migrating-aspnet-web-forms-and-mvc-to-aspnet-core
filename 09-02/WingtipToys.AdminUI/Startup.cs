using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Owin;
using System.Web;

[assembly: OwinStartup(typeof(WingtipToys.AdminUI.Startup))]
namespace WingtipToys.AdminUI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new Microsoft.Owin.Security.Cookies.CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
        }
    }
}