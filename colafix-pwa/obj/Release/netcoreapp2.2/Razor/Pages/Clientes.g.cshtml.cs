#pragma checksum "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6efa77e06705a35dae276a35e07cca482c207140"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(colafix_pwa.Pages.Pages_Clientes), @"mvc.1.0.razor-page", @"/Pages/Clientes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Clientes.cshtml", typeof(colafix_pwa.Pages.Pages_Clientes), null)]
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
#line 2 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
using colafix_pwa.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6efa77e06705a35dae276a35e07cca482c207140", @"/Pages/Clientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e31ec83baf349a7becd61f042957fc79c4f47e7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clientes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
  
    var clientes = (List<Cli>) ViewData["Clientes"];

#line default
#line hidden
            BeginContext(134, 26, true);
            WriteLiteral("\r\n<div class=\"row pt-6\">\r\n");
            EndContext();
#line 9 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
     foreach (var cliente in clientes)
    {

#line default
#line hidden
            BeginContext(207, 125, true);
            WriteLiteral("        <div class=\"col-12\">\r\n            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    ");
            EndContext();
            BeginContext(333, 12, false);
#line 14 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
               Write(cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(345, 182, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-6\">\r\n                            ");
            EndContext();
            BeginContext(528, 12, false);
#line 19 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
                       Write(cliente.Fone);

#line default
#line hidden
            EndContext();
            BeginContext(540, 207, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"card-footer\">\r\n                    <button class=\"btn waves-effect waves-light\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 747, "\"", 799, 6);
            WriteAttributeValue("", 757, "AddRemoveCli(", 757, 13, true);
#line 24 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
WriteAttributeValue("", 770, cliente.Id, 770, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 781, ",", 781, 1, true);
            WriteAttributeValue(" ", 782, "\'", 783, 2, true);
#line 24 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
WriteAttributeValue("", 784, cliente.Nome, 784, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 797, "\')", 797, 2, true);
            EndWriteAttribute();
            BeginContext(800, 82, true);
            WriteLiteral(">Selecionar</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 28 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
    }

#line default
#line hidden
            BeginContext(889, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(918, 114, true);
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function(){\r\n            ShowCurrentCli();\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<colafix_pwa.Pages.ClientesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<colafix_pwa.Pages.ClientesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<colafix_pwa.Pages.ClientesModel>)PageContext?.ViewData;
        public colafix_pwa.Pages.ClientesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
