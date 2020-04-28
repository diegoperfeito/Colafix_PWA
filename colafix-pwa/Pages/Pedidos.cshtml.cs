using colafix_pwa.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace colafix_pwa.Pages
{
    public class PedidosRelatorioModel : PageModel
    {
        public void OnGet(int id, int codCliente)
        {
            ViewData["Title"] = "Pedidos";
            ViewData["PedidosRelatorio"] = Api.GetConsultaPedidosListaVendedor(id,codCliente);
        }
    }
}