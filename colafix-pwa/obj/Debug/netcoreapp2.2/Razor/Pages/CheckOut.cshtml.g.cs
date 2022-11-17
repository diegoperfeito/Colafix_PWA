#pragma checksum "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\Colafix_PWA\colafix-pwa\Pages\CheckOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c7bf02ee6ad2a1b1f957f95b93e249c783b75c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(colafix_pwa.Pages.Pages_CheckOut), @"mvc.1.0.razor-page", @"/Pages/CheckOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/CheckOut.cshtml", typeof(colafix_pwa.Pages.Pages_CheckOut), null)]
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
#line 1 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\Colafix_PWA\colafix-pwa\Pages\_ViewImports.cshtml"
using colafix_pwa;

#line default
#line hidden
#line 2 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\Colafix_PWA\colafix-pwa\Pages\CheckOut.cshtml"
using colafix_pwa.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c7bf02ee6ad2a1b1f957f95b93e249c783b75c2", @"/Pages/CheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e31ec83baf349a7becd61f042957fc79c4f47e7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CheckOut : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\Colafix_PWA\colafix-pwa\Pages\CheckOut.cshtml"
  
    var locaisCobranca = (List<LocalCobranca>)ViewData["LocaisCobranca"];
    var transacoes = (List<Transacao>)ViewData["Transacoes"];
    var empresas = (List<Empresa>)ViewData["Empresas"];

#line default
#line hidden
            BeginContext(275, 1510, true);
            WriteLiteral(@"<div class=""row pt-6"" style='margin-bottom:0'>
    <div id=""cartData""></div>
</div>

<div class='row' style='margin-bottom:0'>
    <div class='col-12'>
        <label class=""label-select"" style=""color: var(--theme-color)"" for=""cbxempresas""><b>Empresa de Faturamento</b></label>
        <select id=""cbxempresas""></select>
        <span class=""highlight""></span>
        <span class=""bar""></span>
    </div>
</div>

<div class='row' style='margin-bottom:0'>
    <div class='col-12'>
        <label class=""label-select"" style=""color: var(--theme-color)"" for=""cbxtransacoes""><b>Tipo de Transação</b></label>
        <select id=""cbxtransacoes""></select>
        <span class=""highlight""></span>
        <span class=""bar""></span>
    </div>
</div>

<div class='row' style='margin-bottom:0'>
    <div class='col-12'>
        <label class=""label-select"" style=""color: var(--theme-color)"" for=""cbxlocaiscobranca""><b>Forma de Pagamento</b></label>
        <select id=""cbxlocaiscobranca""></select>
        <spa");
            WriteLiteral(@"n class=""highlight""></span>
        <span class=""bar""></span>
    </div>
</div>

<div class='row' style='margin-bottom:0'>
    <div class='col-12'>
        <label class=""label-select"" style=""color: var(--theme-color)"" for=""cbxtipofrete""><b>Tipo de Frete</b></label>
        <select id=""cbxtipofrete""></select>
        <span class=""highlight""></span>
        <span class=""bar""></span>
    </div>
</div>

<div class=""row pt-6"">
    <div id=""cartInfo""></div>
</div>



");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1804, 2433, true);
                WriteLiteral(@"
    <script src=""../js/cart.js""></script>
    <script>
        $(document).ready(function () {
            ShowCurrentCli();
            ShowCart();
            ShowInfo();
            //BuildEmpresa();
            //BuildTransacao();
            //BuildLocalCobranca();
            document.getElementById('cartIcon').style.display = 'none';
            document.getElementById('finishIcon').style.display = 'block';

            $('#cbxtransacoes').formSelect();
            $('#cbxlocaiscobranca').formSelect();
            $('#cbxempresas').formSelect();
            $('#cbxtipofrete').formSelect();

            $('#cbxtransacoes option:nth-child(1)').prop(""selected"", true);
            $('#cbxlocaiscobranca option:nth-child(1)').prop(""selected"", true);
            $('#cbxempresas option:nth-child(1)').prop(""selected"", true);
            $('#cbxtipofrete option:nth-child(1)').prop(""selected"", true);
        });

        var currencyInput = document.querySelector('input[type=""currency""]')");
                WriteLiteral(@";
        var currency = 'R$'; // https://www.currency-iso.org/dam/downloads/lists/list_one.xml

        const lstEmpresa = document.getElementById('cbxempresas');
        carregaEmpresa();

        const lstTransacao = document.getElementById('cbxtransacoes');
        carregaTransacao();

        const lstLocalCobranca = document.getElementById('cbxlocaiscobranca');
        carregaLocalCobranca();

        const lstTipoFrete = document.getElementById('cbxtipofrete');
        carregaTipoFrete();

        //currencyInput.addEventListener('focus', onFocus);
        //currencyInput.addEventListener('blur', onBlur);

        function localStringToNumber(s) {
            return Number(String(s).replace(/[^0-9.-]+/g, """"));
        }

        function onFocus(e) {
            const value = e.target.value;
            e.target.value = value ? localStringToNumber(value) : '';
        }

        function onBlur(e) {
            const value = e.target.value;
            const options = {
  ");
                WriteLiteral(@"              maximumFractionDigits: 2,
                currency: currency,
                style: ""currency"",
                currencyDisplay: ""symbol""
            }
            e.target.value = value
                ? localStringToNumber(value).toLocaleString(undefined, options)
                : '';
        }

        function carregaEmpresa() {
            var json = ");
                EndContext();
                BeginContext(4238, 34, false);
#line 121 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\Colafix_PWA\colafix-pwa\Pages\CheckOut.cshtml"
                  Write(Html.Raw(Json.Serialize(empresas)));

#line default
#line hidden
                EndContext();
                BeginContext(4272, 419, true);
                WriteLiteral(@";
            console.log(json);
            json.forEach(funcEmpresa);
        }
        function funcEmpresa(item) {
            const option = document.createElement(""option"");
            option.value = item.codEmp;
            option.innerHTML = item.codEmp + ' - ' + item.nomeEmp;
            lstEmpresa.appendChild(option);
        }

        function carregaLocalCobranca() {
            var json = ");
                EndContext();
                BeginContext(4692, 40, false);
#line 133 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\Colafix_PWA\colafix-pwa\Pages\CheckOut.cshtml"
                  Write(Html.Raw(Json.Serialize(locaisCobranca)));

#line default
#line hidden
                EndContext();
                BeginContext(4732, 430, true);
                WriteLiteral(@";
            var i;
            json.forEach(funcLocalCobranca);
        }
        function funcLocalCobranca(item) {
            const option = document.createElement(""option"");
            option.value = item.codLocCob;
            option.innerHTML = item.codLocCob + ' - ' + item.nomeLocCob;
            lstLocalCobranca.appendChild(option);
        }

        function carregaTransacao() {
            var json = ");
                EndContext();
                BeginContext(5163, 36, false);
#line 145 "E:\Redir_Pasta\Projetos\Visual Studio 2019\Projects\Colafix_PWA\colafix-pwa\Pages\CheckOut.cshtml"
                  Write(Html.Raw(Json.Serialize(transacoes)));

#line default
#line hidden
                EndContext();
                BeginContext(5199, 1157, true);
                WriteLiteral(@";
            var i;
            json.forEach(funcTransacao);
        }
        function funcTransacao(item) {
            const option = document.createElement(""option"");
            option.value = item.codTran;
            option.innerHTML = item.codTran + ' - ' + item.nomeTran;
            lstTransacao.appendChild(option);
        }

        function carregaTipoFrete() {
            const option = document.createElement(""option"");
            option.value = ""1"";
            option.innerHTML = ""CIF""
            lstTipoFrete.appendChild(option);

            const option2 = document.createElement(""option"");
            option2.value = ""2"";
            option2.innerHTML = ""FOB""
            lstTipoFrete.appendChild(option2);

            const option3 = document.createElement(""option"");
            option3.value = ""3"";
            option3.innerHTML = ""REPASSADO""
            lstTipoFrete.appendChild(option3);

            option4 = document.createElement(""option"");
            option");
                WriteLiteral("4.value = \"4\";\r\n            option4.innerHTML = \"PROPRIO\"\r\n            lstTipoFrete.appendChild(option4);\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<colafix_pwa.Pages.CheckOutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<colafix_pwa.Pages.CheckOutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<colafix_pwa.Pages.CheckOutModel>)PageContext?.ViewData;
        public colafix_pwa.Pages.CheckOutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
