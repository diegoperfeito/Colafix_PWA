using colafix_pwa.Model;
using colafix_pwa.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace colafix_pwa.Pages
{
    public class ProdutosSemComprasModel : PageModel
    {
        public void OnGet(int id)
        {
            ViewData["Title"] = "Produtos Sem Compras";
            ViewData["Menu"] = Api.GetProdutosSemCompra(id);
        }
    }
}