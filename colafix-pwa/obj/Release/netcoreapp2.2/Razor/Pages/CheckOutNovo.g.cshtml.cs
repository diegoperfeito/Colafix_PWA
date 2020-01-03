#pragma checksum "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "710336192e86dd8b07e1761da29e45502dc303b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(colafix_pwa.Pages.Pages_CheckOutNovo), @"mvc.1.0.razor-page", @"/Pages/CheckOutNovo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/CheckOutNovo.cshtml", typeof(colafix_pwa.Pages.Pages_CheckOutNovo), null)]
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
#line 2 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
using colafix_pwa.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"710336192e86dd8b07e1761da29e45502dc303b7", @"/Pages/CheckOutNovo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e31ec83baf349a7becd61f042957fc79c4f47e7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CheckOutNovo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
  
    var locaisCobranca = (List<LocalCobranca>)ViewData["LocaisCobranca"];
    var transacoes = (List<Transacao>)ViewData["Transacoes"];
    var empresas = (List<Empresa>)ViewData["Empresas"];

#line default
#line hidden
            BeginContext(275, 344, true);
            WriteLiteral(@"
<div class=""row pt-6"" style='margin-bottom:0'>
    <div id=""cartData""></div>
</div>

<div class='row' style='margin-bottom:0'>
    <div class=""col-sm-12"">
        <ul class=""collapsible"" id=""colemp"">
            <li>
                <div class=""collapsible-header""><i class=""material-icons"">remove_red_eye</i>Seleciona Empresa</div>
");
            EndContext();
#line 19 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
                 foreach (var emp in empresas)
                {

#line default
#line hidden
            BeginContext(686, 58, true);
            WriteLiteral("                <div class=\"verificar collapsible-body\">\r\n");
            EndContext();
            BeginContext(834, 25, true);
            WriteLiteral("                    <span");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 859, "\"", 909, 5);
            WriteAttributeValue("", 869, "selEmpresa(\'", 869, 12, true);
#line 23 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
WriteAttributeValue("", 881, emp.CodEmp, 881, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 892, "\',\'", 892, 3, true);
#line 23 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
WriteAttributeValue("", 895, emp.NomeEmp, 895, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 907, "\')", 907, 2, true);
            EndWriteAttribute();
            BeginContext(910, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(912, 11, false);
#line 23 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
                                                                        Write(emp.NomeEmp);

#line default
#line hidden
            EndContext();
            BeginContext(923, 57, true);
            WriteLiteral("</span>\r\n                    <label style=\"float: right\">");
            EndContext();
            BeginContext(981, 10, false);
#line 24 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
                                           Write(emp.CodEmp);

#line default
#line hidden
            EndContext();
            BeginContext(991, 34, true);
            WriteLiteral("</label>\r\n                </div>\r\n");
            EndContext();
#line 26 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
                }

#line default
#line hidden
            BeginContext(1044, 644, true);
            WriteLiteral(@"            </li>
        </ul>
    </div>
</div>


<div class=""row"" style='margin-bottom:0'>
    <div class='col-12'>
        <span>Empresa: </span><label id='labelEmpresa' style='font-weight:bold'></label>
    </div>
    <div class='col-12'>
        <input type=""text"" disabled id=""txtEmpresa"" class=""form-control"" style='text-align:left' />
    </div>
</div>


<div class='row' style='margin-bottom:0'>
    <div class=""col-sm-12"">
        <ul class=""collapsible"" id=""coltran"">
            <li>
                <div class=""collapsible-header""><i class=""material-icons"">remove_red_eye</i>Selecione Tipo de Transacao</div>
");
            EndContext();
#line 48 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
                 foreach (var emp in transacoes)
                {

#line default
#line hidden
            BeginContext(1757, 58, true);
            WriteLiteral("                <div class=\"verificar collapsible-body\">\r\n");
            EndContext();
            BeginContext(1905, 25, true);
            WriteLiteral("                    <span");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1930, "\"", 1984, 5);
            WriteAttributeValue("", 1940, "selTransacao(\'", 1940, 14, true);
#line 52 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
WriteAttributeValue("", 1954, emp.CodTran, 1954, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1966, "\',\'", 1966, 3, true);
#line 52 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
WriteAttributeValue("", 1969, emp.NomeTran, 1969, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1982, "\')", 1982, 2, true);
            EndWriteAttribute();
            BeginContext(1985, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1987, 12, false);
#line 52 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
                                                                            Write(emp.NomeTran);

#line default
#line hidden
            EndContext();
            BeginContext(1999, 57, true);
            WriteLiteral("</span>\r\n                    <label style=\"float: right\">");
            EndContext();
            BeginContext(2057, 11, false);
#line 53 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
                                           Write(emp.CodTran);

#line default
#line hidden
            EndContext();
            BeginContext(2068, 34, true);
            WriteLiteral("</label>\r\n                </div>\r\n");
            EndContext();
#line 55 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
                }

#line default
#line hidden
            BeginContext(2121, 632, true);
            WriteLiteral(@"            </li>
        </ul>
    </div>
</div>

<div class='row'>
    <div class='col-12'>
        <span>Tipo de Transação: </span><label id='labelTransacao' style='font-weight:bold'></label>
    </div>
    <div class='col-12'>
        <input type=""text"" disabled id=""txtTransacao"" class=""form-control"" style='text-align:left' />
    </div>
</div>


<div class='row' style='margin-bottom:0'>
    <div class=""col-sm-12"">
        <ul class=""collapsible"" id=""colcob"">
            <li>
                <div class=""collapsible-header""><i class=""material-icons"">remove_red_eye</i>Selecione Forma de Pagamento</div>
");
            EndContext();
#line 76 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
                 foreach (var emp in locaisCobranca)
                {

#line default
#line hidden
            BeginContext(2826, 58, true);
            WriteLiteral("                <div class=\"verificar collapsible-body\">\r\n");
            EndContext();
            BeginContext(2974, 25, true);
            WriteLiteral("                    <span");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2999, "\"", 3061, 5);
            WriteAttributeValue("", 3009, "selLocalCobranca(\'", 3009, 18, true);
#line 80 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
WriteAttributeValue("", 3027, emp.CodLocCob, 3027, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 3041, "\',\'", 3041, 3, true);
#line 80 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
WriteAttributeValue("", 3044, emp.NomeLocCob, 3044, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3059, "\')", 3059, 2, true);
            EndWriteAttribute();
            BeginContext(3062, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3064, 14, false);
#line 80 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
                                                                                    Write(emp.NomeLocCob);

#line default
#line hidden
            EndContext();
            BeginContext(3078, 57, true);
            WriteLiteral("</span>\r\n                    <label style=\"float: right\">");
            EndContext();
            BeginContext(3136, 13, false);
#line 81 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
                                           Write(emp.CodLocCob);

#line default
#line hidden
            EndContext();
            BeginContext(3149, 34, true);
            WriteLiteral("</label>\r\n                </div>\r\n");
            EndContext();
#line 83 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
                }

#line default
#line hidden
            BeginContext(3202, 700, true);
            WriteLiteral(@"            </li>
        </ul>
    </div>
</div>


<div class='row'>
    <div class='col-12'>
        <span>Forma de Pagamento: </span><label id='labelLocalCobranca' style='font-weight:bold'></label>
    </div>
    <div class='col-12'>
        <input type=""text"" disabled id=""txtLocalCobranca"" class=""form-control"" style='text-align:left'   />
    </div>
</div>


<div class='row' style='margin-bottom:0'>
    <div class=""col-sm-12"">
        <ul class=""collapsible"" id=""colfrete"">
            <li>
                <div class=""collapsible-header""><i class=""material-icons"">remove_red_eye</i>Selecione Tipo de Frete</div>
                <div class=""verificar collapsible-body"">
");
            EndContext();
            BeginContext(3992, 213, true);
            WriteLiteral("                    <span onclick=\"selTipoFrete(\'1\',\'CIF\')\">CIF</span>\r\n                    <label style=\"float: right\">1</label>\r\n                </div>\r\n                <div class=\"verificar collapsible-body\">\r\n");
            EndContext();
            BeginContext(4295, 213, true);
            WriteLiteral("                    <span onclick=\"selTipoFrete(\'2\',\'FOB\')\">FOB</span>\r\n                    <label style=\"float: right\">2</label>\r\n                </div>\r\n                <div class=\"verificar collapsible-body\">\r\n");
            EndContext();
            BeginContext(4598, 225, true);
            WriteLiteral("                    <span onclick=\"selTipoFrete(\'3\',\'REPASSADO\')\">REPASSADO</span>\r\n                    <label style=\"float: right\">3</label>\r\n                </div>\r\n                <div class=\"verificar collapsible-body\">\r\n");
            EndContext();
            BeginContext(4913, 591, true);
            WriteLiteral(@"                    <span onclick=""selTipoFrete('4','PROPRIO')"">PROPRIO</span>
                    <label style=""float: right"">4</label>
                </div>
            </li>
        </ul>
    </div>
</div>


<div class='row'>
    <div class='col-12'>
        <span>Tipo de Frete: </span><label id='labelTipoFrete' style='font-weight:bold'></label>
    </div>
    <div class='col-12'>
        <input type=""text"" disabled id=""txtTipoFrete"" class=""form-control"" style='text-align:left' />
    </div>
</div>

<div class=""row"">
    <div id=""cartInfo""></div>
</div>



");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5523, 1556, true);
                WriteLiteral(@"
    <script src=""../js/cart.js""></script>
    <script>
    $(document).ready(function () {
            $('.collapsible').collapsible();
            ShowCurrentCli();
            ShowCart();
            ShowInfo();
            //BuildEmpresa();
            //BuildTransacao();
            //BuildLocalCobranca();
            document.getElementById('cartIcon').style.display = 'none';
            document.getElementById('finishIcon').style.display = 'block';
        });

        var currencyInput = document.querySelector('input[type=""currency""]');
        var currency = 'R$'; // https://www.currency-iso.org/dam/downloads/lists/list_one.xml

        //currencyInput.addEventListener('focus', onFocus);
        //currencyInput.addEventListener('blur', onBlur);

        function localStringToNumber(s) {
            return Number(String(s).replace(/[^0-9.-]+/g, """"));
        }

        function onFocus(e) {
            const value = e.target.value;
            e.target.value = value ? localS");
                WriteLiteral(@"tringToNumber(value) : '';
        }

        function onBlur(e) {
            const value = e.target.value;
            const options = {
                maximumFractionDigits: 2,
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
                BeginContext(7080, 34, false);
#line 191 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
                  Write(Html.Raw(Json.Serialize(empresas)));

#line default
#line hidden
                EndContext();
                BeginContext(7114, 419, true);
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
                BeginContext(7534, 40, false);
#line 203 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
                  Write(Html.Raw(Json.Serialize(locaisCobranca)));

#line default
#line hidden
                EndContext();
                BeginContext(7574, 430, true);
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
                BeginContext(8005, 36, false);
#line 215 "C:\workspace\colafix-pwa\colafix-pwa\Pages\CheckOutNovo.cshtml"
                  Write(Html.Raw(Json.Serialize(transacoes)));

#line default
#line hidden
                EndContext();
                BeginContext(8041, 2224, true);
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
                WriteLiteral(@"4.value = ""4"";
            option4.innerHTML = ""PROPRIO""
            lstTipoFrete.appendChild(option4);
        }

        function selEmpresa(codEmp, nomeEmp) {
            var inputF = document.getElementById(""txtEmpresa"");
            const txt = codEmp + ' - '+ nomeEmp;
            inputF.setAttribute('value', txt);
            $('.collapsible').collapsible('close');

        }

        function selTransacao(cod,nome) {
            var inputF = document.getElementById(""txtTransacao"");
            const txt = cod + ' - '+ nome;
            inputF.setAttribute('value', txt);
            $('.collapsible').collapsible('close');

        }

        function selLocalCobranca(cod,nome) {
        var inputF = document.getElementById(""txtLocalCobranca"");
        const txt = cod + ' - '+ nome;
        inputF.setAttribute('value', txt);
        $('.collapsible').collapsible('close');

        }

        function selTipoFrete(cod,nome) {
        var inputF = document.getElementById(""txtT");
                WriteLiteral("ipoFrete\");\r\n        const txt = cod + \' - \'+ nome;\r\n        inputF.setAttribute(\'value\', txt);\r\n        $(\'.collapsible\').collapsible(\'close\');\r\n\r\n        }\r\n\r\n    </script>\r\n");
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