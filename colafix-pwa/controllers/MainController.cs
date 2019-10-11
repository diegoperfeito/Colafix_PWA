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
    }
}