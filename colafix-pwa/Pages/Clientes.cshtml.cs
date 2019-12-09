using colafix_pwa.Model;
using colafix_pwa.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace colafix_pwa.Pages
{
    public class ClientesModel : PageModel
    {
        public void OnGet(int id, string admin)
        {
            ViewData["Title"] = "Clientes";
            if (admin == "0")
            {
                ViewData["Clientes"] = Api.GetCliForLista(id);
            }
            else
            {
                List<Cli> cli = new List<Cli>();
                ViewData["Clientes"] = cli;
            }
        }
    }
}