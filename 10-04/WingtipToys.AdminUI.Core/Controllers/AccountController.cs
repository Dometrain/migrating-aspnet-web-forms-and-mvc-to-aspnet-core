using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace WingtipToys.AdminUI.Core.Controllers
{
    public class AccountController : Controller
    {
        [ValidateAntiForgeryToken]
        [HttpPost("/Account/LogOff")]
        public IActionResult LogOff()
        {
            HttpContext.SignOutAsync("SharedCookie");
            return Redirect("/");
        }
    }
}
