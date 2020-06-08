#pragma checksum "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fca15318d332341647fd55bec01809428f2c34e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(colafix_pwa.Pages.Pages_Financeiro), @"mvc.1.0.razor-page", @"/Pages/Financeiro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Financeiro.cshtml", typeof(colafix_pwa.Pages.Pages_Financeiro), null)]
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
#line 2 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
using colafix_pwa.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fca15318d332341647fd55bec01809428f2c34e3", @"/Pages/Financeiro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e31ec83baf349a7becd61f042957fc79c4f47e7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Financeiro : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
  
    var titulos = (Financeiro)ViewData["titulos"];
    var classe = "col-12 padrao";

#line default
#line hidden
            BeginContext(169, 408, true);
            WriteLiteral(@"
<div class=""row pt-6"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""col-sm-12"">
                    <b>Totalizadores</b>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <b>Em Aberto:</b> R$ ");
            EndContext();
            BeginContext(578, 21, false);
#line 20 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
                                        Write(titulos.TotalEmAberto);

#line default
#line hidden
            EndContext();
            BeginContext(599, 188, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-12\">\r\n                        <b>Aberto em Cartório:</b> R$ ");
            EndContext();
            BeginContext(788, 29, false);
#line 25 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
                                                 Write(titulos.TotalEmAbertoCartorio);

#line default
#line hidden
            EndContext();
            BeginContext(817, 188, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-12\">\r\n                        <b>Aberto em Protesto:</b> R$ ");
            EndContext();
            BeginContext(1006, 29, false);
#line 30 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
                                                 Write(titulos.TotalEmAbertoProtesto);

#line default
#line hidden
            EndContext();
            BeginContext(1035, 177, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-12\">\r\n                        <b>Vencido:</b> R$ ");
            EndContext();
            BeginContext(1213, 20, false);
#line 35 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
                                      Write(titulos.TotalVencido);

#line default
#line hidden
            EndContext();
            BeginContext(1233, 178, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-12\">\r\n                        <b>A Vencer:</b> R$ ");
            EndContext();
            BeginContext(1412, 20, false);
#line 40 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
                                       Write(titulos.TotalAVencer);

#line default
#line hidden
            EndContext();
            BeginContext(1432, 176, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-12\">\r\n                        <b>Limite:</b> R$ ");
            EndContext();
            BeginContext(1609, 19, false);
#line 45 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
                                     Write(titulos.ValorLimite);

#line default
#line hidden
            EndContext();
            BeginContext(1628, 187, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-12\">\r\n                        <b>Limite Disponível:</b> R$ ");
            EndContext();
            BeginContext(1816, 29, false);
#line 50 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
                                                Write(titulos.TotalLimiteDisponivel);

#line default
#line hidden
            EndContext();
            BeginContext(1845, 76, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");
            EndContext();
            BeginContext(2141, 57, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 63 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
     foreach (var titulo in titulos.FinanceiroTitulo)
    {



#line default
#line hidden
            BeginContext(2264, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2272, "\"", 2287, 1);
#line 67 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
WriteAttributeValue("", 2280, classe, 2280, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2288, 187, true);
            WriteLiteral(">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-12\">\r\n                        <b>Título:</b> ");
            EndContext();
            BeginContext(2476, 13, false);
#line 72 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
                                  Write(titulo.CodTit);

#line default
#line hidden
            EndContext();
            BeginContext(2489, 41, true);
            WriteLiteral("<br />\r\n                        Parcela: ");
            EndContext();
            BeginContext(2531, 14, false);
#line 73 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
                            Write(titulo.DesdTit);

#line default
#line hidden
            EndContext();
            BeginContext(2545, 44, true);
            WriteLiteral("<br />\r\n                        Vencimento: ");
            EndContext();
            BeginContext(2590, 24, false);
#line 74 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
                               Write(titulo.DtVencimFormatado);

#line default
#line hidden
            EndContext();
            BeginContext(2614, 42, true);
            WriteLiteral("<br />\r\n                        Saldo: R$ ");
            EndContext();
            BeginContext(2657, 21, false);
#line 75 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
                             Write(titulo.SaldoFormatado);

#line default
#line hidden
            EndContext();
            BeginContext(2678, 108, true);
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 81 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
        classe = "col-12 padrao";
    }

#line default
#line hidden
            BeginContext(2828, 14, true);
            WriteLiteral("</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2861, 267, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('.collapsible').collapsible();
            ShowCurrentCli();

            $(document).ready(function () {
                $('#filtro').formSelect();
            });

            var json = ");
                EndContext();
                BeginContext(3129, 33, false);
#line 98 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Financeiro.cshtml"
                  Write(Html.Raw(Json.Serialize(titulos)));

#line default
#line hidden
                EndContext();
                BeginContext(3162, 1919, true);
                WriteLiteral(@";
            console.log(json);
        });

        function filtrar(cod,nome) {
            var divs = document.getElementsByClassName('padrao');
            console.log(divs);
            for (var i = 0; i < divs.length; i++) {
                divs[i].style.display = ""none"";
            }
            var fil = cod;
            if (fil == '1') {
                var divs = document.getElementsByClassName('pendente');
                console.log(divs);
                for (var i = 0; i < divs.length; i++) {
                    divs[i].style.display = ""block"";
                }
            } else if (fil == '2') {
                var divs = document.getElementsByClassName('analise');
                console.log(divs);
                for (var i = 0; i < divs.length; i++) {
                    divs[i].style.display = ""block"";
                }
            } else if (fil == '3') {
                var divs = document.getElementsByClassName('credito');
                console.log(divs);
");
                WriteLiteral(@"                for (var i = 0; i < divs.length; i++) {
                    divs[i].style.display = ""block"";
                }
            } else if (fil == '4') {
                var divs = document.getElementsByClassName('liquidado');
                console.log(divs);
                for (var i = 0; i < divs.length; i++) {
                    divs[i].style.display = ""block"";
                }
            } else if (fil == '5') {
                var divs = document.getElementsByClassName('reprovado');
                console.log(divs);
                for (var i = 0; i < divs.length; i++) {
                    divs[i].style.display = ""block"";
                }
            }
            $('.collapsible').collapsible('close');
       }

        function mostraDetalhe(id) {
            RedirectAction(""/PedidoDetalhe/?id="".concat(id));
        }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<colafix_pwa.Pages.FinanceiroModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<colafix_pwa.Pages.FinanceiroModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<colafix_pwa.Pages.FinanceiroModel>)PageContext?.ViewData;
        public colafix_pwa.Pages.FinanceiroModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
