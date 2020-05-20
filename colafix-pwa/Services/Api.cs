using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using colafix_pwa.Model;
using Newtonsoft.Json;
using Vitsoftol.Hurdle;

namespace colafix_pwa.Services
{
    public static class Api
    {
        private static void ShowPassword(ref Credential credential)
        {
            var shield = new Shield(CryptProvider.Rijndael);
            credential.Senha = shield.UnLock(credential.Senha);
        }

        private static string BaseUrl()
        {
            //return "http://remoto.colafix.com:9292/Colafix/appservice.svc/";
             return "http://localhost:11954/appservice.svc/";
           // return "http://127.0.0.1:9292/Colafix/appservice.svc/";
            // return "http://200.98.172.139/Colafix/appservice.svc/";
        }

        private static string BuildCall(HttpClient httpClient, string endPoint)
        {
            var url = $"{BaseUrl()}{endPoint}";
            httpClient.DefaultRequestHeaders.Add("token", "96166124-03ce-40b4-9496-0f17718fe620");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return url;
        }

        public static LogedUser Login(Credential obj)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "login");
                    var apiResult = 
                        JsonConvert.DeserializeObject<LoginResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.LoginResultLoginResult.State != 1)
                    {
                        throw new Exception(apiResult.LoginResultLoginResult.Message);
                    }

                    var usuario = apiResult.LoginResultLoginResult.Data;

                    //Criptografa senha para guardar local já que a senha não é retornada. Melhor que seja assim.
                    var shield = new Shield(CryptProvider.Rijndael);
                    usuario.Senha = shield.Lock(obj.Senha);

                    return usuario;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static Boolean UsuarioAtivo(Credential obj)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "usuarioAtivo");
                    var apiResult =
                        JsonConvert.DeserializeObject<UsuarioAtivoResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.UsuarioAtivoResultUsuarioAtivoResult.State != 1)
                    {
                        return false;
                    }

                    var usuario = apiResult.UsuarioAtivoResultUsuarioAtivoResult.Data;

                    ////Criptografa senha para guardar local já que a senha não é retornada. Melhor que seja assim.
                    //var shield = new Shield(CryptProvider.Rijndael);
                    //usuario.Senha = shield.Lock(obj.Senha);

                    return true;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }


        public static List<ProductGroup> GetMenu(Credential obj)
        {
            try
            {
                //ShowPassword(ref obj);

                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "getMenu");
                    var apiResult = 
                        JsonConvert.DeserializeObject<GetMenuResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.GetMenuResultData.State != 1)
                    {
                        throw new Exception(apiResult.GetMenuResultData.Message);
                    }

                    return apiResult.GetMenuResultData.ProductGroup;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static Product GetProduto(dynamic obj)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "getProduto");
                    var apiResult =
                        JsonConvert.DeserializeObject<GetProdutoResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.GetProdutoResultData.State != 1)
                    {
                        throw new Exception(apiResult.GetProdutoResultData.Message);
                    }
                    return apiResult.GetProdutoResultData.Product;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static ProdutoUltimaCompra GetProdutoUltimaCompra(dynamic obj)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "getProdutoUltimaCompra");
                    var apiResult =
                        JsonConvert.DeserializeObject<GetProdutoUltimaCompraResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.GetProdutoUltimaCompraResultData.State != 1)
                    {
                        throw new Exception(apiResult.GetProdutoUltimaCompraResultData.Message);
                    }
                    return apiResult.GetProdutoUltimaCompraResultData.ProdutoUltimaCompra;
                }
            }
            catch (Exception exception)
            {
                ProdutoUltimaCompra produtoUltimaCompra = new ProdutoUltimaCompra();
                produtoUltimaCompra.DataUltimaCompra = "00/00/0000";
                produtoUltimaCompra.QuantidadeUltimaCompra = 0;
                produtoUltimaCompra.PedidoUltimaCompra = 0;
                produtoUltimaCompra.ValorUltimaCompra = "";
                return produtoUltimaCompra;
            }
        }


        public static List<Cli> GetCliForLista(int codRepresentante)
        {
            try
            {
                dynamic obj = new ExpandoObject();
                obj.codRepresentante = codRepresentante;

                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "GetCliForLista");
                    var apiResult = 
                        JsonConvert.DeserializeObject<GetCliForListaResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.GetCliForListaResultGetCliForListaResult.State != 1)
                    {
                        throw new Exception(apiResult.GetCliForListaResultGetCliForListaResult.Message);
                    }

                    return apiResult.GetCliForListaResultGetCliForListaResult.Clientes;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static List<Empresa> GetUsuarioEmpresaLista(string usuario)
        {
            try
            {
                dynamic obj = new ExpandoObject();
                obj.usuario = usuario;
                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "GetUsuarioEmpresaLista");
                    var apiResult =
                        JsonConvert.DeserializeObject<GetUsuarioEmpresaListaResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.GetUsuarioEmpresaListaResultData.State != 1)
                    {
                        throw new Exception(apiResult.GetUsuarioEmpresaListaResultData.Message);
                    }

                    return apiResult.GetUsuarioEmpresaListaResultData.Empresa;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static List<LocalCobranca> GetLocaisCobrancaLista()
        {
            try
            {
                dynamic obj = new ExpandoObject();
                obj.codLocalCobranca = "";
                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "GetLocaisCobrancaLista");
                    var apiResult =
                        JsonConvert.DeserializeObject<GetLocaisCobrancaListaResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.GetLocaisCobrancaListaResultData.State != 1)
                    {
                        throw new Exception(apiResult.GetLocaisCobrancaListaResultData.Message);
                    }

                    return apiResult.GetLocaisCobrancaListaResultData.LocalCobranca;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static List<Transacao> GetTransacoesLista()
        {
            try
            {
                dynamic obj = new ExpandoObject();
                obj.usuario = "";
                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "GetTransacoesLista");
                    var apiResult =
                        JsonConvert.DeserializeObject<GetTransacoesListaResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.GetTransacoesListaResultData.State != 1)
                    {
                        throw new Exception(apiResult.GetTransacoesListaResultData.Message);
                    }

                    return apiResult.GetTransacoesListaResultData.Transacao;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static PedidoNovo InsertPedidoApp(dynamic obj)
        {
            try
            {
                string x = JsonConvert.SerializeObject(obj.BodyData);

                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "InsertPedidoApp");
                    var apiResult =
                        JsonConvert.DeserializeObject<InsertPedidoAppResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj.BodyData), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.InsertPedidoAppResultData.State == -1)
                    {
                        throw new Exception(apiResult.InsertPedidoAppResultData.Message);
                    }

                    return apiResult.InsertPedidoAppResultData.PedidoNovo;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }


        public static void EnviaEmailPedido(dynamic obj)
        {
            try
            {
                string x = JsonConvert.SerializeObject(obj.BodyData);

                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "EnviaEmailPedido");
                     var apiResult =
                        JsonConvert.DeserializeObject<EnviaEmailPedidoResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj.BodyData), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.EnviaEmailPedidoResultData.State != 1)
                    {
                        throw new Exception(apiResult.EnviaEmailPedidoResultData.Message);
                    }

                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }




        public static PedidosRelatorio GetConsultaPedidosListaVendedor(int codVend, int codCli)
        {
            try
            {
                dynamic obj = new ExpandoObject();
                obj.codVend = codVend;
                obj.codCli = codCli;

                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "GetConsultaPedidosListaVendedor");
                    var apiResult =
                        JsonConvert.DeserializeObject<GetConsultaPedidosListaVendedorResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.GetConsultaPedidosListaVendedorResultData.State != 1)
                    {
                        throw new Exception(apiResult.GetConsultaPedidosListaVendedorResultData.Message);
                    }

                    return apiResult.GetConsultaPedidosListaVendedorResultData.PedidosRelatorio;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static PedidoApp GetUltimoPedido(int codCliente)
        {
            try
            {
                dynamic obj = new ExpandoObject();
                obj.codCliente = codCliente;

                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "GetConsultaUltimoPedidoCliente");
                    var apiResult =
                        JsonConvert.DeserializeObject<GetConsultaUltimoPedidoClienteResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.GetConsultaUltimoPedidoClienteResultData.State != 1)
                    {
                        throw new Exception(apiResult.GetConsultaUltimoPedidoClienteResultData.Message);
                    }

                    PedidoApp pedidoApp = apiResult.GetConsultaUltimoPedidoClienteResultData.PedidosRelatorio;

                    return pedidoApp;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }




        public static Financeiro GetClienteFinanceiro(int codCliente)
        {
            try
            {
                dynamic obj = new ExpandoObject();
                obj.codCliente = codCliente;

                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "GetClienteFinanceiro");
                    var apiResult =
                        JsonConvert.DeserializeObject<GetClienteFinanceiroResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.GetClienteFinanceiroResultData.State != 1)
                    {
                        throw new Exception(apiResult.GetClienteFinanceiroResultData.Message);
                    }

                    return apiResult.GetClienteFinanceiroResultData.Financeiro;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static PedidoApp GetConsultaPedido(int codPed)
        {
            try
            {
                dynamic obj = new ExpandoObject();
                obj.codPed = codPed;

                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "GetConsultaPedido");
                    var apiResult =
                        JsonConvert.DeserializeObject<GetConsultaPedidoResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.GetConsultaPedidoResultData.State != 1)
                    {
                        throw new Exception(apiResult.GetConsultaPedidoResultData.Message);
                    }

                    return apiResult.GetConsultaPedidoResultData.PedidoApp;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }


        public static List<Cli> GetCliForAdminLista(dynamic obj)
        {
            try
            {

                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "GetCliForAdminLista");
                    var apiResult =
                        JsonConvert.DeserializeObject<GetCliForAdminListaResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj.BodyData), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.GetCliForAdminListaResultData.State != 1)
                    {
                        throw new Exception(apiResult.GetCliForAdminListaResultData.Message);
                    }

                    return apiResult.GetCliForAdminListaResultData.Clientes;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static List<ProductGroup> GetProdutosSemCompra(int codCliente)
        {
            try
            {
                dynamic obj = new ExpandoObject();
                obj.codCliente = codCliente;

                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "getProdutosSemCompra");
                    var apiResult =
                        JsonConvert.DeserializeObject<GetProdutosSemComprasResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.GetProdutosSemComprasResultData.State != 1)
                    {
                        throw new Exception(apiResult.GetProdutosSemComprasResultData.Message);
                    }

                    return apiResult.GetProdutosSemComprasResultData.ProductGroup;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }


        public static List<Entrega> GetEntregas(string placaVeiculo)
        {
            try
            {
                dynamic obj = new ExpandoObject();
                obj.placaVeiculo = placaVeiculo;

                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "getEntregas");
                    var apiResult =
                        JsonConvert.DeserializeObject<GetEntregasResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.GetEntregasResultData.State != 1)
                    {
                        throw new Exception(apiResult.GetEntregasResultData.Message);
                    }

                    return apiResult.GetEntregasResultData.Entregas;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }


        public static string UpdateSituacaoPedidoApp(string pedidoId)
        {
            try
            {

                dynamic obj = new ExpandoObject();
                obj.pedidoId = pedidoId;
                obj.situacao = "ANALISE";

                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "updateSituacaoPedidoApp");
                    var apiResult =
                        JsonConvert.DeserializeObject<UpdateSituacaoPedidoAppResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.UpdateSituacaoPedidoAppResultData.State == -1)
                    {
                        throw new Exception(apiResult.UpdateSituacaoPedidoAppResultData.Message);
                    }

                    return apiResult.UpdateSituacaoPedidoAppResultData.PedidoApp;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }


        public static string DeletePedidoApp(string deletePedidoId)
        {
            try
            {

                dynamic obj = new ExpandoObject();
                obj.deletePedidoId = deletePedidoId;

                using (var httpClient = new HttpClient())
                {
                    var url = BuildCall(httpClient, "deletePedidoApp");
                    var apiResult =
                        JsonConvert.DeserializeObject<DeletePedidoAppResult>(
                            httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result
                        );
                    if (apiResult.DeletePedidoAppResultData.State == -1)
                    {
                        throw new Exception(apiResult.DeletePedidoAppResultData.Message);
                    }

                    return apiResult.DeletePedidoAppResultData.PedidoApp;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

    }
}
