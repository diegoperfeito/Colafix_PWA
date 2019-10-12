using colafix_pwa.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace colafix_pwa.Pages
{
    public class ClientesModel : PageModel
    {
        public void OnGet(int id)
        {
            ViewData["Title"] = "Clientes";
            ViewData["Clientes"] = Api.GetCliForLista(id);
        }
    }
}