using System.IO;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Interop;
using Owin;

[assembly: OwinStartup(typeof(WingtipToys.AdminUI.Startup))]
namespace WingtipToys.AdminUI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                CookieName = ".AspNet.SharedCookie",
                TicketDataFormat = new AspNetTicketDataFormat(new DataProtectorShim(DataProtectionProvider.Create(
                new DirectoryInfo(Path.Combine(Path.GetTempPath(), "sharedkeys", "WingtipToys.Admin")),
                    builder => builder.SetApplicationName("WingtipToys.Admin"))
                    .CreateProtector(
                        "Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationMiddleware",
                        "SharedCookie",
                        "v2")))
            });
        }
    }
}