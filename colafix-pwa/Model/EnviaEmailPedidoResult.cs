using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public partial class EnviaEmailPedidoResult
    {
        [JsonProperty("EnviaEmailPedidoResult")]
        public EnviaEmailPedidoResultData EnviaEmailPedidoResultData { get; set; }
    }

    public class EnviaEmailPedidoResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public string email { get; set; }
    }

    public partial class EnviaEmailPedidoResult
    {
        public static EnviaEmailPedidoResult FromJson(string json) => JsonConvert.DeserializeObject<EnviaEmailPedidoResult>(json, Converter.Settings);
    }
}
