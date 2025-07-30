using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WingtipToys.ShopUI.Core.Pages
{
    [Authorize]
    public class ContactModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
