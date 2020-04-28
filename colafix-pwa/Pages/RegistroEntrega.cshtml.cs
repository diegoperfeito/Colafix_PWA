using System.Dynamic;
using colafix_pwa.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace colafix_pwa.Pages
{
    public class RegistroEntregaModel : PageModel
    {
        public void OnGet(string placaVeiculo)
        {
            ViewData["Title"] = "Registro de Entrega";
            ViewData["Entregas"] = Api.GetEntregas(placaVeiculo);
        }
    }
}