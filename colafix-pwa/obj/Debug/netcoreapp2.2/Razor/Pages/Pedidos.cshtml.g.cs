#pragma checksum "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df1bdd7613cc6294139eef3b5540d3dc5ea1d54c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(colafix_pwa.Pages.Pages_Pedidos), @"mvc.1.0.razor-page", @"/Pages/Pedidos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Pedidos.cshtml", typeof(colafix_pwa.Pages.Pages_Pedidos), null)]
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
#line 1 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\_ViewImports.cshtml"
using colafix_pwa;

#line default
#line hidden
#line 2 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml"
using colafix_pwa.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df1bdd7613cc6294139eef3b5540d3dc5ea1d54c", @"/Pages/Pedidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e31ec83baf349a7becd61f042957fc79c4f47e7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pedidos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml"
  
    var pedidosRelatorio = (PedidosRelatorio)ViewData["PedidosRelatorio"];
    var classe = "col-12 padrao";

#line default
#line hidden
            BeginContext(199, 404, true);
            WriteLiteral(@"
<div class=""row pt-6"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""col-sm-12"">
                    Totais de Pedidos
                </div>
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <b>Pendente:</b> R$ ");
            EndContext();
            BeginContext(604, 30, false);
#line 20 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml"
                                       Write(pedidosRelatorio.TotalPendente);

#line default
#line hidden
            EndContext();
            BeginContext(634, 177, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-12\">\r\n                        <b>Análise:</b> R$ ");
            EndContext();
            BeginContext(812, 29, false);
#line 25 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml"
                                      Write(pedidosRelatorio.TotalAnalise);

#line default
#line hidden
            EndContext();
            BeginContext(841, 177, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-12\">\r\n                        <b>Crédito:</b> R$ ");
            EndContext();
            BeginContext(1019, 29, false);
#line 30 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml"
                                      Write(pedidosRelatorio.TotalCredito);

#line default
#line hidden
            EndContext();
            BeginContext(1048, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
            BeginContext(1317, 125, true);
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-sm-12\">\r\n                        <b>Reprovado:</b> R$ ");
            EndContext();
            BeginContext(1443, 31, false);
#line 40 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml"
                                        Write(pedidosRelatorio.TotalReprovado);

#line default
#line hidden
            EndContext();
            BeginContext(1474, 74, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
            BeginContext(1768, 38, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2157, 1148, true);
            WriteLiteral(@"

<div class='row' style='margin-bottom:0'>
    <div class=""col-sm-12"">
        <ul class=""collapsible"" id=""colfrete"">
            <li>
                <div class=""collapsible-header""><i class=""material-icons"">remove_red_eye</i><b>Selecione Situação</b></div>
                <div class=""verificar collapsible-body"">
                    <span onclick=""filtrar('1','PENDENTE')"">Pendente</span>
                </div>
                <div class=""verificar collapsible-body"">
                    <span onclick=""filtrar('2','ANALISE')"">Análise</span>
                </div>
                <div class=""verificar collapsible-body"">
                    <span onclick=""filtrar('3','CREDITO')"">Crédito</span>
                </div>
                <div class=""verificar collapsible-body"">
                    <span onclick=""filtrar('4','LIQUIDADO')"">Liquidado</span>
                </div>
                <div class=""verificar collapsible-body"">
                    <span onclick=""filtrar('5','REPROVADO')"">Repr");
            WriteLiteral("ovado</span>\r\n                </div>\r\n\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<div class=\"row pt-6\">\r\n");
            EndContext();
#line 90 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml"
     foreach (var pedido in pedidosRelatorio.PedidosAapp)
    {


        classe += pedido.Situacao == "PENDENTE"
            ? " pendente"
            : pedido.Situacao == "ANALISE"
                ? " analise"
                : pedido.Situacao == "CREDITO"
                ? " credito"
                : pedido.Situacao == "LIQUIDADO" ? " liquidado" : "reprovado";



#line default
#line hidden
            BeginContext(3687, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3695, "\"", 3710, 1);
#line 103 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml"
WriteAttributeValue("", 3703, classe, 3703, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3711, 167, true);
            WriteLiteral(" style=\"display:none\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                <div class=\"col-sm-12\">\r\n                    <b>Pedido:</b> ");
            EndContext();
            BeginContext(3879, 9, false);
#line 107 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml"
                              Write(pedido.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3888, 17, true);
            WriteLiteral(" <b>Emissão:</b> ");
            EndContext();
            BeginContext(3906, 18, false);
#line 107 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml"
                                                         Write(pedido.DataEmissao);

#line default
#line hidden
            EndContext();
            BeginContext(3924, 203, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-12\">\r\n                        <b>Cliente:</b> ");
            EndContext();
            BeginContext(4128, 14, false);
#line 113 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml"
                                   Write(pedido.NomeCli);

#line default
#line hidden
            EndContext();
            BeginContext(4142, 170, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-12\">\r\n                        <b>Obs:</b> ");
            EndContext();
            BeginContext(4313, 10, false);
#line 118 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml"
                               Write(pedido.Obs);

#line default
#line hidden
            EndContext();
            BeginContext(4323, 175, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-12\">\r\n                        <b>Situação:</b> ");
            EndContext();
            BeginContext(4499, 15, false);
#line 123 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml"
                                    Write(pedido.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(4514, 182, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-12\">\r\n                        <b>Total do Pedido:</b> ");
            EndContext();
            BeginContext(4697, 37, false);
#line 128 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml"
                                           Write(string.Format("{0:C}", pedido.VlrTot));

#line default
#line hidden
            EndContext();
            BeginContext(4734, 175, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"card-footer\">\r\n                    <button class=\"btn waves-effect waves-light\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4909, "\"", 4944, 3);
            WriteAttributeValue("", 4919, "mostraDetalhe(", 4919, 14, true);
#line 132 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml"
WriteAttributeValue("", 4933, pedido.Id, 4933, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 4943, ")", 4943, 1, true);
            EndWriteAttribute();
            BeginContext(4945, 56, true);
            WriteLiteral(">Detalhes do Pedido</button>\r\n                </div>\r\n\r\n");
            EndContext();
            BeginContext(5376, 48, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 145 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\colafix-pwa\colafix-pwa\Pages\Pedidos.cshtml"
        classe = "col-12 padrao";
    }

#line default
#line hidden
            BeginContext(5466, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5495, 2157, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('.collapsible').collapsible();
            ShowCurrentCli();

            $(document).ready(function () {
                $('#filtro').formSelect();
            });
        });

        function filtrar(cod,nome) {
            var divs = document.getElementsByClassName('padrao');
            console.log(divs);
            for (var i = 0; i < divs.length; i++) {
                divs[i].style.display = ""none"";
            }
            var fil = cod;
            console.log(fil);
            if (fil == '1') {
                var divs = document.getElementsByClassName('pendente');
                console.log(divs);
                for (var i = 0; i < divs.length; i++) {
                    divs[i].style.display = ""block"";
                }
            } else if (fil == '2') {
                var divs = document.getElementsByClassName('analise');
                console.log(divs);
                for (var i = 0; i < di");
                WriteLiteral(@"vs.length; i++) {
                    divs[i].style.display = ""block"";
                }
            } else if (fil == '3') {
                var divs = document.getElementsByClassName('credito');
                console.log(divs);
                for (var i = 0; i < divs.length; i++) {
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

        function mos");
                WriteLiteral("traDetalhe(id) {\r\n            RedirectAction(\"/PedidoDetalhe/?id=\".concat(id));\r\n        }\r\n\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<colafix_pwa.Pages.PedidosRelatorioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<colafix_pwa.Pages.PedidosRelatorioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<colafix_pwa.Pages.PedidosRelatorioModel>)PageContext?.ViewData;
        public colafix_pwa.Pages.PedidosRelatorioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
