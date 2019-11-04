using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public partial class InsertPedidoAppResult
    {
        [JsonProperty("InsertPedidoAppResult")]
        public InsertPedidoAppResultData InsertPedidoAppResultData { get; set; }
    }

    public class InsertPedidoAppResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public PedidoApp PedidoApp { get; set; }
    }

    public partial class InsertPedidoAppResult
    {
        public static InsertPedidoAppResult FromJson(string json) => JsonConvert.DeserializeObject<InsertPedidoAppResult>(json, Converter.Settings);
    }
}
