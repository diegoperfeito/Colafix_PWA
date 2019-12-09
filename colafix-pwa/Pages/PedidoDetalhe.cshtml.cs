using colafix_pwa.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace colafix_pwa.Pages
{
    public class PedidoDetalheModel : PageModel
    {
        public void OnGet(int id)
        {
            ViewData["Title"] = "Pedido";
            ViewData["Pedido"] = Api.GetConsultaPedido(id);
        }
    }
}