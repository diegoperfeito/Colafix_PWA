using colafix_pwa.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace colafix_pwa.Pages
{
    public class CheckOutModel : PageModel
    {
        public void OnGet(string usuario)
        {
            ViewData["Title"] = "Checkout";
            ViewData["LocaisCobranca"] = Api.GetLocaisCobrancaLista();
            ViewData["Transacoes"] = Api.GetTransacoesLista();
            ViewData["Empresas"] = Api.GetUsuarioEmpresaLista(usuario);
        }
    }
}