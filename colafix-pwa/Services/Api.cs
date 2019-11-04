﻿using System;
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
            return "http://54.94.137.107/Colafix/appservice.svc/";
            // return "http://localhost:11954/appservice.svc/";
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

        public static List<Empresa> GetUsuarioEmpresaLista(dynamic obj)
        {
            try
            {
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

        public static List<LocalCobranca> GetLocaisCobrancaLista(dynamic obj)
        {
            try
            {
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

        public static List<Transacao> GetTransacoesLista(dynamic obj)
        {
            try
            {
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

        public static PedidoApp InsertPedidoApp(dynamic obj)
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
                    if (apiResult.InsertPedidoAppResultData.State != 1)
                    {
                        throw new Exception(apiResult.InsertPedidoAppResultData.Message);
                    }

                    return apiResult.InsertPedidoAppResultData.PedidoApp;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
