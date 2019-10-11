﻿using colafix_pwa.Model;
using colafix_pwa.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace colafix_pwa.Pages
{
    public class MenuModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "Menu";

            var cred = new Credential
            {
                Usuario = "simone",
                Senha = "fran"
            };

            ViewData["Menu"] = Api.GetMenu(cred);
        }
    }
}