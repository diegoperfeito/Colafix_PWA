using colafix_pwa.Model;
using colafix_pwa.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace colafix_pwa.Pages
{
    public class MenuModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "Menu v." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString().Substring(0,5);

            //TODO Melhorar isso, definir tipos de menu ao logar e manter a credencial
            var cred = new Credential
            {
                Usuario = "simone",
                Senha = "fran"
            };

            ViewData["Menu"] = Api.GetMenu(cred);
        }
    }
}