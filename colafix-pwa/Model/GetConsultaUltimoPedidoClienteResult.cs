using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class GetConsultaUltimoPedidoClienteResult
    {
        [JsonProperty("GetConsultaUltimoPedidoClienteResult")]
        public GetConsultaUltimoPedidoClienteResultData GetConsultaUltimoPedidoClienteResultData { get; set; }
    }

    public class GetConsultaUltimoPedidoClienteResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public PedidoApp PedidosRelatorio { get; set; }
    }
}
