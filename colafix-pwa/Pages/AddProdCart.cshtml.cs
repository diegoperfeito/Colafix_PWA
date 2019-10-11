using Microsoft.AspNetCore.Mvc.RazorPages;

namespace colafix_pwa.Pages
{
    public class AddProdCartModel : PageModel
    {
        public void OnGet(int id)
        {
            ViewData["Title"] = "Adicionar ao carrinho";
            //Recupera produto para transportar para esta tela. Precisa endpoint

            //ViewData["Produto"] = Api.GetProduto(id)
        }
    }
}