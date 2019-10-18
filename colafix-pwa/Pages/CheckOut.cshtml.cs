using Microsoft.AspNetCore.Mvc.RazorPages;

namespace colafix_pwa.Pages
{
    public class CheckOutModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "Checkout";
        }
    }
}