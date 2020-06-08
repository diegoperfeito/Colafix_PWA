using System;
using System.Linq;
using colafix_pwa.Model;
using colafix_pwa.Services;
using colafix_pwa.Utils;
using Microsoft.AspNetCore.Mvc;

namespace colafix_pwa.controllers
{
    public class MainController : Controller
    {
        public ActionResult Login([FromBody] Credential obj)
        {
            try
            {
                var data = Api.Login(obj);
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Success,
                    Message = "Bem-vindo",
                    Title = "Sucesso",
                    EmbeddedData = data
                }));
            }
            catch (Exception exception)
            {
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Failure,
                    Message = exception.Message,
                    Title = "Erro de Sistema"
                }));
            }
        }

        public ActionResult UsuarioAtivo([FromBody] Credential obj)
        {
            try
            {
                var data = Api.UsuarioAtivo(obj);
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Success,
                    Message = "Bem-vindo",
                    Title = "Sucesso",
                    EmbeddedData = data
                }));
            }
            catch (Exception exception)
            {
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Failure,
                    Message = exception.Message,
                    Title = "Erro de Sistema"
                }));
            }
        }


        public ActionResult GetMenu([FromBody] Credential obj)
        {
            try
            {
                var data = Api.GetMenu(obj);
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Success,
                    Message = "Menu carregado com suceso",
                    Title = "Sucesso",
                    EmbeddedData = data
                }));
            }
            catch (Exception exception)
            {
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Failure,
                    Message = exception.Message,
                    Title = "Erro de Sistema"
                }));
            }
        }

        public ActionResult GetProduto([FromBody] dynamic obj)
        {
            try
            {
                var data = Api.GetProduto(obj.BodyData);
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Success,
                    Message = "Produto encontrado",
                    Title = "Sucesso",
                    EmbeddedData = data
                }));
            }
            catch (Exception exception)
            {
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Failure,
                    Message = exception.Message,
                    Title = "Erro de Sistema"
                }));
            }
        }

        public ActionResult GetUsuarioEmpresaLista([FromBody] dynamic obj)
        {
            try
            {
                var data = Api.GetUsuarioEmpresaLista(obj);
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Success,
                    Message = "Produto encontrado",
                    Title = "Sucesso",
                    EmbeddedData = data
                }));
            }
            catch (Exception exception)
            {
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Failure,
                    Message = exception.Message,
                    Title = "Erro de Sistema"
                }));
            }
        }

        public ActionResult GetLocaisCobrancaLista([FromBody] dynamic obj)
        {
            try
            {
                var data = Api.GetLocaisCobrancaLista();
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Success,
                    Message = "Produto encontrado",
                    Title = "Sucesso",
                    EmbeddedData = data
                }));
            }
            catch (Exception exception)
            {
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Failure,
                    Message = exception.Message,
                    Title = "Erro de Sistema"
                }));
            }
        }



        public ActionResult GetTransacoesLista([FromBody] dynamic obj)
        {
            try
            {
                var data = Api.GetTransacoesLista();
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Success,
                    Message = "Produto encontrado",
                    Title = "Sucesso",
                    EmbeddedData = data
                }));
            }
            catch (Exception exception)
            {
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Failure,
                    Message = exception.Message,
                    Title = "Erro de Sistema"
                }));
            }
        }


        public ActionResult GetCliForAdminLista([FromBody] dynamic obj)
        {
            try
            {
                var data = Api.GetCliForAdminLista(obj);
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Success,
                    Message = "Cliente não encontrato",
                    Title = "Sucesso",
                    EmbeddedData = data
                }));
            }
            catch (Exception exception)
            {
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Failure,
                    Message = exception.Message,
                    Title = "Erro de Sistema"
                }));
            }
        }



        public ActionResult InsertPedidoApp([FromBody] dynamic obj)
        {
            try
            {
                PedidoNovo data = Api.InsertPedidoApp(obj);

                if(data.Criticas.Count() > 0)
                {
                    return Json(AjaxMessage.Create(new MessageContent
                    {
                        MessageType = MessageType.Warning,
                        Message = "Produto encontrado",
                        Title = "Sucesso",
                        EmbeddedData = data
                    }));
                }else
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Success,
                    Message = "Produto encontrado",
                    Title = "Sucesso",
                    EmbeddedData = data
                }));
            }
            catch (Exception exception)
            {
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Failure,
                    Message = exception.Message,
                    Title = "Erro de Sistema"
                }));
            }
        }


        public ActionResult EnviaEmailPedido([FromBody] dynamic obj)
        {
            try
            {
                Api.EnviaEmailPedido(obj);
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Success,
                    Message = "Email Enviado",
                    Title = "Sucesso",

                }));
            }
            catch (Exception exception)
            {
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Failure,
                    Message = exception.Message,
                    Title = "Erro de Sistema"
                }));
            }
        }


        public ActionResult UpdateSituacaoPedidoApp([FromBody] dynamic obj)
        {
            try
            {
                string pedidoId = obj.BodyData.pedidoId;
                var data = Api.UpdateSituacaoPedidoApp(pedidoId);
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Success,
                    Message = "Produto encontrado",
                    Title = "Sucesso",
                    EmbeddedData = data
                }));
            }
            catch (Exception exception)
            {
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Failure,
                    Message = exception.Message,
                    Title = "Erro de Sistema"
                }));
            }
        }


        public ActionResult DeletePedidoApp([FromBody] dynamic obj)
        {
            try
            {
                string deletePedidoId = obj.BodyData.deletePedidoId;
                var data = Api.DeletePedidoApp(deletePedidoId);
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Success,
                    Message = "Pedido Deletado",
                    Title = "Sucesso",
                    EmbeddedData = data
                }));
            }
            catch (Exception exception)
            {
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Failure,
                    Message = exception.Message,
                    Title = "Erro de Sistema"
                }));
            }
        }

        public ActionResult UpdateClienteEmpilhadeira([FromBody] dynamic obj)
        {
            try
            {
                string id = obj.BodyData.Id;
                int temEmpilhadeira = obj.BodyData.TemEmpilhadeira;
                var data = Api.UpdateClienteEmpilhadeira(id, temEmpilhadeira);
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Success,
                    Message = "Cliente alterado",
                    Title = "Sucesso",
                    EmbeddedData = data
                }));
            }
            catch (Exception exception)
            {
                return Json(AjaxMessage.Create(new MessageContent
                {
                    MessageType = MessageType.Failure,
                    Message = exception.Message,
                    Title = "Erro de Sistema"
                }));
            }
        }


    }
}