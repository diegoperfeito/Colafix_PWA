#pragma checksum "C:\workspace\colafix-pwa\colafix-pwa\Pages\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ac6f17ddd9f668da7e1e2271eb5cd35f17bcffb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(colafix_pwa.Pages.Pages_Menu), @"mvc.1.0.razor-page", @"/Pages/Menu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Menu.cshtml", typeof(colafix_pwa.Pages.Pages_Menu), null)]
namespace colafix_pwa.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\workspace\colafix-pwa\colafix-pwa\Pages\_ViewImports.cshtml"
using colafix_pwa;

#line default
#line hidden
#line 2 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Menu.cshtml"
using colafix_pwa.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ac6f17ddd9f668da7e1e2271eb5cd35f17bcffb", @"/Pages/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e31ec83baf349a7becd61f042957fc79c4f47e7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Menu : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Menu.cshtml"
  
    var menu = (List<ProductGroup>)ViewData["Menu"];

#line default
#line hidden
            DefineSection("Style", async() => {
                BeginContext(145, 29, true);
                WriteLiteral("\r\n    <style>\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(177, 509, true);
            WriteLiteral(@"<div class=""row pt-6"">
    <div class=""row"">
        <div class=""col-3"" align=""center"">
            <label class=""pt-10"">Código</label>
        </div>
        <div class=""col-6"" align=""left"">
            <input type=""number"" name=""cod"" id=""cod"" class=""form-control weight"" value="""" />
        </div>
        <div class=""col-3"" align=""left"">
            <button class=""btn waves-effect waves-light"" onclick=""buscar()"">
                OK
            </button>
        </div>
    </div>
</div>

");
            EndContext();
#line 27 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Menu.cshtml"
 foreach (var productGroup in menu)
{

#line default
#line hidden
            BeginContext(726, 173, true);
            WriteLiteral("    <div class=\"col-sm-12\">\r\n        <ul class=\"collapsible\">\r\n            <li>\r\n                <div class=\"collapsible-header\"><i class=\"material-icons\">remove_red_eye</i>");
            EndContext();
            BeginContext(900, 17, false);
#line 32 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Menu.cshtml"
                                                                                       Write(productGroup.Name);

#line default
#line hidden
            EndContext();
            BeginContext(917, 12, true);
            WriteLiteral("&nbsp;<span>");
            EndContext();
            BeginContext(931, 43, false);
#line 32 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Menu.cshtml"
                                                                                                                      Write($"({productGroup.Products.Count} produtos)");

#line default
#line hidden
            EndContext();
            BeginContext(975, 15, true);
            WriteLiteral("</span></div>\r\n");
            EndContext();
#line 33 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Menu.cshtml"
                 foreach (var product in productGroup.Products)
                {

#line default
#line hidden
            BeginContext(1074, 59, true);
            WriteLiteral("                    <div class=\"verificar collapsible-body\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1133, "\"", 1154, 1);
#line 35 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Menu.cshtml"
WriteAttributeValue("", 1138, product.CodProd, 1138, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1155, 32, true);
            WriteLiteral(">\r\n                        <span");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1187, "\"", 1224, 3);
            WriteAttributeValue("", 1197, "AddCart(\'", 1197, 9, true);
#line 36 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Menu.cshtml"
WriteAttributeValue("", 1206, product.CodProd, 1206, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 1222, "\')", 1222, 2, true);
            EndWriteAttribute();
            BeginContext(1225, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1227, 16, false);
#line 36 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Menu.cshtml"
                                                               Write(product.NomeProd);

#line default
#line hidden
            EndContext();
            BeginContext(1243, 61, true);
            WriteLiteral("</span>\r\n                        <label style=\"float: right\">");
            EndContext();
            BeginContext(1305, 15, false);
#line 37 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Menu.cshtml"
                                               Write(product.CodProd);

#line default
#line hidden
            EndContext();
            BeginContext(1320, 38, true);
            WriteLiteral("</label>\r\n                    </div>\r\n");
            EndContext();
#line 39 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Menu.cshtml"
                }

#line default
#line hidden
            BeginContext(1377, 46, true);
            WriteLiteral("            </li>\r\n        </ul>\r\n    </div>\r\n");
            EndContext();
#line 43 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Menu.cshtml"
}

#line default
#line hidden
            BeginContext(1426, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1451, 1470, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('.collapsible').collapsible();
            ShowCurrentCli();
        });

        function AddCart(id) {
            if (currentCli === null) {
                Notiflix.Report.Warning(
                    'Atenção',
                    'É necessário selecionar um cliente antes',
                    'Selecione um cliente');
                return;
            }
            window.location.href = ""/AddProdCart/?id="".concat(id).concat(""&codCli="").concat(currentCli.Id);
        }



    function buscar() {
        var lista = document.getElementsByClassName('verificar');
        console.log(lista);
        var codProd = document.getElementById(""cod"").value;
        codProd = leftPad(codProd, 6);
        var achei = false;
        for (var i = 0; i < lista.length; i++) {
            if (codProd === lista[i].id) {
                achei = true;
                break;
            }
        }
        if (achei) {
     ");
                WriteLiteral(@"       AddCart(codProd)
        } else {
            Notiflix.Report.Info(
                'Atenção',
                'Produto inválido ou não disponível no APP',
                'Fechar');
            return;
        }
    }

    function leftPad(value, totalWidth, paddingChar) {
        var length = totalWidth - value.toString().length + 1;
        return Array(length).join(paddingChar || '0') + value;
    };

    </script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<colafix_pwa.Pages.MenuModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<colafix_pwa.Pages.MenuModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<colafix_pwa.Pages.MenuModel>)PageContext?.ViewData;
        public colafix_pwa.Pages.MenuModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
