#pragma checksum "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c858e22c23ebfe6b9c61eaa917712b0754e5b5ab"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c858e22c23ebfe6b9c61eaa917712b0754e5b5ab", @"/Pages/Clientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e31ec83baf349a7becd61f042957fc79c4f47e7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clientes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
  
    List<Cli> clientes = (List<Cli>)ViewData["Clientes"];

#line default
#line hidden
            BeginContext(139, 555, true);
            WriteLiteral(@"
<div class=""row pt-6"">
    <div class=""row"">
        <div class=""col-12"" align=""left"">
            <label class=""pt-10"">Pesquisa por Nome do Cliente</label>
        </div>
        <div class=""col-9"" align=""left"">
            <input type=""text"" name=""cli"" id=""cli"" class=""form-control"" value="""" />
        </div>
        <div class=""col-3"" align=""left"">
            <button class=""btn waves-effect waves-light"" onclick=""buscarAdmin(cli.value)"">
                OK
            </button>
        </div>
    </div>
</div>

<div id=""dados"">
");
            EndContext();
            BeginContext(2680, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2711, 336, true);
                WriteLiteral(@"
        <script>
        $(document).ready(function(){
            ShowCurrentCli();
            if (currentUser.admin != ""1"") {
                buscar("""");
            }
        });


    function buscar(obj) {
        var x = obj;
        var html = """";
        html = `<div class=""row"">
            <div class=""row"">
");
                EndContext();
#line 86 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
                 foreach (var cliente in clientes)
                {

#line default
#line hidden
                BeginContext(3118, 188, true);
                WriteLiteral("                    <div class=\"col-12\">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-header\">\r\n                                <b>Código: </b>");
                EndContext();
                BeginContext(3307, 10, false);
#line 91 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
                                          Write(cliente.Id);

#line default
#line hidden
                EndContext();
                BeginContext(3317, 14, true);
                WriteLiteral(" <b>Nome: </b>");
                EndContext();
                BeginContext(3332, 12, false);
#line 91 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
                                                                   Write(cliente.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(3344, 55, true);
                WriteLiteral("<br>\r\n                                <b>CNPJ/CPF: </b>");
                EndContext();
                BeginContext(3400, 15, false);
#line 92 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
                                            Write(cliente.CpfCnpj);

#line default
#line hidden
                EndContext();
                BeginContext(3415, 261, true);
                WriteLiteral(@"
                            </div>
                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <b>Fantasia: </b> ");
                EndContext();
                BeginContext(3677, 20, false);
#line 97 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
                                                     Write(cliente.NomeFantasia);

#line default
#line hidden
                EndContext();
                BeginContext(3697, 252, true);
                WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-sm-12\">\r\n                                        <b>Fone: </b> ");
                EndContext();
                BeginContext(3950, 12, false);
#line 102 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
                                                 Write(cliente.Fone);

#line default
#line hidden
                EndContext();
                BeginContext(3962, 256, true);
                WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <b>Endereço: </b> ");
                EndContext();
                BeginContext(4219, 16, false);
#line 107 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
                                                     Write(cliente.Endereco);

#line default
#line hidden
                EndContext();
                BeginContext(4235, 251, true);
                WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-sm-12\">\r\n                                        <b>CEP: </b> ");
                EndContext();
                BeginContext(4487, 11, false);
#line 112 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
                                                Write(cliente.Cep);

#line default
#line hidden
                EndContext();
                BeginContext(4498, 254, true);
                WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-sm-12\">\r\n                                        <b>Bairro: </b> ");
                EndContext();
                BeginContext(4753, 14, false);
#line 117 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
                                                   Write(cliente.Bairro);

#line default
#line hidden
                EndContext();
                BeginContext(4767, 254, true);
                WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-sm-12\">\r\n                                        <b>Cidade: </b> ");
                EndContext();
                BeginContext(5022, 14, false);
#line 122 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
                                                   Write(cliente.Cidade);

#line default
#line hidden
                EndContext();
                BeginContext(5036, 267, true);
                WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""card-footer"">
                                <button class=""btn waves-effect waves-light"" type=""button""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 5303, "\"", 5384, 9);
                WriteAttributeValue("", 5313, "selecionaCliente(", 5313, 17, true);
#line 127 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
WriteAttributeValue("", 5330, cliente.Id, 5330, 11, false);

#line default
#line hidden
                WriteAttributeValue("", 5341, ",", 5341, 1, true);
                WriteAttributeValue(" ", 5342, "\'", 5343, 2, true);
#line 127 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
WriteAttributeValue("", 5344, cliente.Nome, 5344, 13, false);

#line default
#line hidden
                WriteAttributeValue("", 5357, "\',", 5357, 2, true);
                WriteAttributeValue(" ", 5359, "\'", 5360, 2, true);
#line 127 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
WriteAttributeValue("", 5361, cliente.Empilhadeira, 5361, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 5382, "\')", 5382, 2, true);
                EndWriteAttribute();
                BeginContext(5385, 118, true);
                WriteLiteral(">Selecionar</button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 131 "C:\workspace\colafix-pwa\colafix-pwa\Pages\Clientes.cshtml"
                }

#line default
#line hidden
                BeginContext(5522, 7608, true);
                WriteLiteral(@"            </div>`
        html += '</div>'
        document.getElementById('dados').innerHTML = html;
    }

    function buscarAdmin(obj) {
        console.log(currentUser.admin);
        if (currentUser.admin != ""1"") {
            $("".card"").each(function () {
                console.log(""aqui"");
                var resultado = $(this).text().toUpperCase().indexOf(' ' + obj.toUpperCase());
                if (resultado < 0) {
                    $(this).fadeOut();
                } else {
                    $(this).fadeIn();
                }
            });
        } else {

            var x = obj;
            var html = """";
            html = `<div class=""row pt-6"">`

            const o = new Object();
            o.nome = obj;
            $.ajax({
                context: this,
                url: ""/Main/GetCliForAdminLista"",
                type: ""POST"",
                data: BuildData(o),
                contentType: ""application/json; charset=utf-8"",
              ");
                WriteLiteral(@"  dataType: ""json"",
                beforeSend: function () {
                    Notiflix.Loading.Dots(""Aguarde..."");
                },
                success: function (data) {
                    Notiflix.Loading.Remove();
                    const returnData = JSON.parse(data);
                    console.log(returnData);
                    if (returnData.MessageType !== 0) {
                        ShowMessage(data);
                        return;
                    }
                    for (let d = 0; d < returnData.EmbeddedData.length; d++) {
                        html += `<div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <b>Código: </b>${returnData.EmbeddedData[d].id} <b>Nome: </b>${returnData.EmbeddedData[d].nome}<br>
                            <b>CNPJ/CPF: </b>${returnData.EmbeddedData[d].cpfCnpj}
                        </div>
                        <div class=""card-body"">
         ");
                WriteLiteral(@"                   <div class=""row"">
                                <div class=""col-sm-12"">
                                    <b>Fone: </b> ${returnData.EmbeddedData[d].fone}
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-sm-12"">
                                    <b>Endereço: </b> ${returnData.EmbeddedData[d].endereco}
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-sm-12"">
                                    <b>CEP: </b> ${returnData.EmbeddedData[d].cep}
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-sm-12"">
                                    <b>Bairro: </b> ${returnData.EmbeddedData[d].bairro}
                                </d");
                WriteLiteral(@"iv>
                            </div>
                            <div class=""row"">
                                <div class=""col-sm-12"">
                                    <b>Cidade: </b> ${returnData.EmbeddedData[d].cidade}
                                </div>
                            </div>
                        </div>
                        <div class=""card-footer"">
                            <button class=""btn waves-effect waves-light"" type=""button"" onclick=""selecionaCliente(${returnData.EmbeddedData[d].id}, '${returnData.EmbeddedData[d].nome}','${returnData.EmbeddedData[d].empilhadeira}')"">Selecionar</button>
                        </div>
                        </div>
                    </div>`
                    }
                    html += '</div>'
                    document.getElementById('dados').innerHTML = html;
                },
                error: function (data) {
                    Notiflix.Loading.Remove();
                    ShowError(data);
    ");
                WriteLiteral(@"            }
            });
        }
    }

    function cpfCnpj(v){

        //Remove tudo o que não é dígito
        v=v.replace(/\D/g,"""")

        if (v.length <= 14) { //CPF

            //Coloca um ponto entre o terceiro e o quarto dígitos
            v=v.replace(/(\d{3})(\d)/,""$1.$2"")

            //Coloca um ponto entre o terceiro e o quarto dígitos
            //de novo (para o segundo bloco de números)
            v=v.replace(/(\d{3})(\d)/,""$1.$2"")

            //Coloca um hífen entre o terceiro e o quarto dígitos
            v=v.replace(/(\d{3})(\d{1,2})$/,""$1-$2"")

        } else { //CNPJ

            //Coloca ponto entre o segundo e o terceiro dígitos
            v=v.replace(/^(\d{2})(\d)/,""$1.$2"")

            //Coloca ponto entre o quinto e o sexto dígitos
            v=v.replace(/^(\d{2})\.(\d{3})(\d)/,""$1.$2.$3"")

            //Coloca uma barra entre o oitavo e o nono dígitos
            v=v.replace(/\.(\d{3})(\d)/,"".$1/$2"")

            //Coloca um hífen de");
                WriteLiteral(@"pois do bloco de quatro dígitos
            v=v.replace(/(\d{4})(\d)/,""$1-$2"")

        }

        return v

    }

    function selecionaCliente(id, nome, empilhadeira) {
        if (empilhadeira != """") {
            AddRemoveCli(id, nome);
        } else {
            Notiflix.Confirm.Show(
            ""Informar ao sistema!!"",
            ""CLIENTE POSSUI EMPILHADEIRA?"",
            ""Sim"",
            ""Não"",
            function () {
                const obj = new Object();
                obj.Id = id;
                obj.TemEmpilhadeira = 1;
                $.ajax({
                    context: this,
                    url: ""/Main/UpdateClienteEmpilhadeira"",
                    type: ""POST"",
                    data: BuildData(obj),
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""json"",
                    beforeSend: function () {
                        Notiflix.Loading.Dots(""Aguarde..."");
                    },
         ");
                WriteLiteral(@"           success: function (data) {
                        Notiflix.Notify.Success('cliente alterado com sucesso');
                        AddRemoveCli(id, nome);
                    },
                    error: function (data) {
                        Notiflix.Loading.Remove();
                        ShowError(data);
                    }
                });
            },
            function () {
                const obj = new Object();
                obj.Id = id;
                obj.TemEmpilhadeira = 0;
                $.ajax({
                    context: this,
                    url: ""/Main/UpdateClienteEmpilhadeira"",
                    type: ""POST"",
                    data: BuildData(obj),
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""json"",
                    beforeSend: function () {
                        Notiflix.Loading.Dots(""Aguarde..."");
                    },
                    success: function (data) {");
                WriteLiteral(@"
                        Notiflix.Notify.Success('cliente alterado com sucesso');
                        AddRemoveCli(id, nome);
                    },
                    error: function (data) {
                        Notiflix.Loading.Remove();
                        ShowError(data);
                    }
                });
            });
 //           $('#newModal').modal('open');
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<colafix_pwa.Pages.ClientesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<colafix_pwa.Pages.ClientesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<colafix_pwa.Pages.ClientesModel>)PageContext?.ViewData;
        public colafix_pwa.Pages.ClientesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
