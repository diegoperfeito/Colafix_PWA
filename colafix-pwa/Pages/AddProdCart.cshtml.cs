using System.Dynamic;
using colafix_pwa.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace colafix_pwa.Pages
{
    public class AddProdCartModel : PageModel
    {
        public void OnGet(string id, string codCli)
        {
            ViewData["Title"] = "Carrinho";
            //Recupera produto para transportar para esta tela. Precisa endpoint

            dynamic obj = new ExpandoObject();
            obj.codProduto = id;
            ViewData["Produto"] = Api.GetProduto(obj);

            dynamic objCliente = new ExpandoObject();
            objCliente.codProduto = id;
            objCliente.codCliente = codCli;
            ViewData["ProdutoUltimaCompra"] = Api.GetProdutoUltimaCompra(objCliente);
        }
    }
}