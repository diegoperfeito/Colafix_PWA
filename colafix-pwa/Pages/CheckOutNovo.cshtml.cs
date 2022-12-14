using colafix_pwa.Model;
using colafix_pwa.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace colafix_pwa.Pages
{
    public class CheckOutNovoModel : PageModel
    {
        public void OnGet(string usuario, int codCliente)
        {
            ViewData["Title"] = "Checkout";
            ViewData["LocaisCobranca"] = Api.GetLocaisCobrancaLista();
            ViewData["Transacoes"] = Api.GetTransacoesLista();
            ViewData["Empresas"] = Api.GetUsuarioEmpresaLista(usuario);
            ViewData["Pedido"] = Api.GetUltimoPedido(codCliente);
        }
    }
}