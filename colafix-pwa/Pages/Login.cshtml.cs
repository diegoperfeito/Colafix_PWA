using Microsoft.AspNetCore.Mvc.RazorPages;

namespace colafix_pwa.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "Login";
        }
    }
}