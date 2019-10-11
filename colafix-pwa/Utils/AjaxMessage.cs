using Newtonsoft.Json;

namespace colafix_pwa.Utils
{
    /// <summary>
    /// Constroi mensagens de retorno para aplicação
    /// </summary>
    public static class AjaxMessage
    {
        public static string Create(MessageContent messageContent)
        {
            return JsonConvert.SerializeObject(messageContent);
        }
    }

    public class MessageContent
    {
        public MessageContent()
        {
            EmbeddedData = null;
        }

        public MessageType MessageType { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public object EmbeddedData { get; set; }
    }
    public enum MessageType
    {
        Success,
        Failure,
        Warning,
        Info
    }
}
