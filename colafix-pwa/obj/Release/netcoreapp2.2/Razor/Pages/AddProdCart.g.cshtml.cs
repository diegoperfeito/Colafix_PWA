#pragma checksum "C:\workspace\colafix-pwa\colafix-pwa\Pages\AddProdCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60767abf930a709e2405a1f8fdb191f52e94b99e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(colafix_pwa.Pages.Pages_AddProdCart), @"mvc.1.0.razor-page", @"/Pages/AddProdCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AddProdCart.cshtml", typeof(colafix_pwa.Pages.Pages_AddProdCart), null)]
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
#line 2 "C:\workspace\colafix-pwa\colafix-pwa\Pages\AddProdCart.cshtml"
using colafix_pwa.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60767abf930a709e2405a1f8fdb191f52e94b99e", @"/Pages/AddProdCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e31ec83baf349a7becd61f042957fc79c4f47e7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AddProdCart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/cart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\workspace\colafix-pwa\colafix-pwa\Pages\AddProdCart.cshtml"
  
    var produto = (Product)ViewData["Produto"];

#line default
#line hidden
            BeginContext(132, 150, true);
            WriteLiteral("\r\n<div class=\"row pt-6\">\r\n    <div class=\"col-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\" align=\"center\">\r\n                ");
            EndContext();
            BeginContext(283, 15, false);
#line 12 "C:\workspace\colafix-pwa\colafix-pwa\Pages\AddProdCart.cshtml"
           Write(produto.CodProd);

#line default
#line hidden
            EndContext();
            BeginContext(298, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(302, 16, false);
#line 12 "C:\workspace\colafix-pwa\colafix-pwa\Pages\AddProdCart.cshtml"
                              Write(produto.NomeProd);

#line default
#line hidden
            EndContext();
            BeginContext(318, 1228, true);
            WriteLiteral(@"
            </div>
            <div class=""card-tabs"">
                <ul class=""tabs tabs-fixed-width"">
                    <li class=""tab""><a class=""active"" href=""#item"">Item do Pedido</a></li>
                    <li class=""tab""><a href=""#info"">Última Compra</a></li>
                </ul>
            </div>
            <div class=""card-content grey lighten-4"">
                <div id=""item"">
                    <div class=""row"">
                        <div class=""col-6"" align=""center"">
                            <label class=""pt-10"">Quantidade</label>
                        </div>
                        <div class=""col-6"" align=""left"">
                            <input type=""text"" id=""qtdItem"" onkeyup=""calculaItem()"" class=""form-control weight"" value=""0"" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"" align=""center"">
                            <label class=""pt-10"">Preço Unitário</label>");
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-6\" align=\"left\">\r\n                            <input type=\"text\" id=\"valorItem\" onkeyup=\"calculaItem()\" class=\"form-control money\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1546, "\"", 1571, 1);
#line 35 "C:\workspace\colafix-pwa\colafix-pwa\Pages\AddProdCart.cshtml"
WriteAttributeValue("", 1554, produto.CustoRep, 1554, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1572, 266, true);
            WriteLiteral(@" />
                        </div>
                    </div>
                </div>
                <div id=""info"">
                    <div class=""row"">
                        <div class=""col s8"">Embalagem</div>
                        <div class=""col s4"">");
            EndContext();
            BeginContext(1839, 17, false);
#line 42 "C:\workspace\colafix-pwa\colafix-pwa\Pages\AddProdCart.cshtml"
                                       Write(produto.Embalagem);

#line default
#line hidden
            EndContext();
            BeginContext(1856, 177, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col s8\">Pedido</div>\r\n                        <div class=\"col s4\">");
            EndContext();
            BeginContext(2034, 15, false);
#line 46 "C:\workspace\colafix-pwa\colafix-pwa\Pages\AddProdCart.cshtml"
                                       Write(produto.CodProd);

#line default
#line hidden
            EndContext();
            BeginContext(2049, 176, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col s8\"> Data</div>\r\n                        <div class=\"col s4\">");
            EndContext();
            BeginContext(2226, 15, false);
#line 50 "C:\workspace\colafix-pwa\colafix-pwa\Pages\AddProdCart.cshtml"
                                       Write(produto.CodProd);

#line default
#line hidden
            EndContext();
            BeginContext(2241, 182, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col s8\">Quantidade </div>\r\n                        <div class=\"col s4\">");
            EndContext();
            BeginContext(2424, 15, false);
#line 54 "C:\workspace\colafix-pwa\colafix-pwa\Pages\AddProdCart.cshtml"
                                       Write(produto.CodProd);

#line default
#line hidden
            EndContext();
            BeginContext(2439, 186, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col s8\"> Valor Unitário</div>\r\n                        <div class=\"col s4\">");
            EndContext();
            BeginContext(2626, 15, false);
#line 58 "C:\workspace\colafix-pwa\colafix-pwa\Pages\AddProdCart.cshtml"
                                       Write(produto.CodProd);

#line default
#line hidden
            EndContext();
            BeginContext(2641, 736, true);
            WriteLiteral(@"</div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"" align=""center"">
                Total do Item
                <div class=""row"">
                    <div class=""col s12"" align=""center"">
                        <input type=""text"" id=""totalItem"" style=""text-align:center"" class=""form-control money"" disabled=""disabled"" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-12"" align=""center"">
        <button class=""btn waves-effect waves-light"" type=""button""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3377, "\"", 3418, 3);
            WriteAttributeValue("", 3387, "AddCartItem(\'", 3387, 13, true);
#line 81 "C:\workspace\colafix-pwa\colafix-pwa\Pages\AddProdCart.cshtml"
WriteAttributeValue("", 3400, produto.CodProd, 3400, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 3416, "\')", 3416, 2, true);
            EndWriteAttribute();
            BeginContext(3419, 85, true);
            WriteLiteral(" name=\"action\">\r\n            Salvar Item\r\n        </button>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3523, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3529, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60767abf930a709e2405a1f8fdb191f52e94b99e10563", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3565, 689, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            ShowCurrentCli();
            BuildOrder();
            BuildEmpresa();
            BuildLocalCobranca();
            $('#qtdItem').focus();
            $('#qtdItem').select();
        });

        var valorItem;
        var totalAmount = 0;

        function calculaItem() {
            valorItem = document.getElementById(""valorItem"").value;
            valorItem = valorItem.replace("","", ""."");

            totalAmount = document.getElementById(""qtdItem"").value * valorItem;
            document.getElementById(""totalItem"").value = totalAmount.toString().replace(""."", "","");
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(4257, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<colafix_pwa.Pages.AddProdCartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<colafix_pwa.Pages.AddProdCartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<colafix_pwa.Pages.AddProdCartModel>)PageContext?.ViewData;
        public colafix_pwa.Pages.AddProdCartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591