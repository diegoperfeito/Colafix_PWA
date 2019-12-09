using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class GetConsultaPedidoResult
    {
        [JsonProperty("GetConsultaPedidoResult")]
        public GetConsultaPedidoResultData GetConsultaPedidoResultData { get; set; }
    }

    public class GetConsultaPedidoResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public PedidoApp PedidoApp { get; set; }
    }
}
