using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public partial class DeletePedidoAppResult
    {
        [JsonProperty("DeletePedidoAppResult")]
        public DeletePedidoAppResultData DeletePedidoAppResultData { get; set; }
    }

    public class DeletePedidoAppResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public string PedidoApp { get; set; }
    }

    public partial class DeletePedidoAppResult
    {
        public static DeletePedidoAppResult FromJson(string json) => JsonConvert.DeserializeObject<DeletePedidoAppResult>(json, Converter.Settings);
    }
}
