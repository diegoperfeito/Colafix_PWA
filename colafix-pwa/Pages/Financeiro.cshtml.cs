using colafix_pwa.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace colafix_pwa.Pages
{
    public class FinanceiroModel : PageModel
    {
        public void OnGet(int id)
        {
            ViewData["Title"] = "Financeiro";
            ViewData["titulos"] = Api.GetClienteFinanceiro(id);
        }
    }
}