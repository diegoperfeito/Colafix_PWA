using System;
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
                var data = Api.GetUsuarioEmpresaLista(obj.BodyData);
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
                var data = Api.GetLocaisCobrancaLista(obj.BodyData);
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
                var data = Api.GetTransacoesLista(obj.BodyData);
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



        public ActionResult InsertPedidoApp([FromBody] dynamic obj)
        {
            try
            {
                var data = Api.InsertPedidoApp(obj);
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

    }
}