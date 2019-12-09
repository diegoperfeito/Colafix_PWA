using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class GetConsultaPedidosListaVendedorResult
    {
        [JsonProperty("GetConsultaPedidosListaVendedorResult")]
        public GetConsultaPedidosListaVendedorResultData GetConsultaPedidosListaVendedorResultData { get; set; }
    }

    public class GetConsultaPedidosListaVendedorResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public PedidosRelatorio PedidosRelatorio { get; set; }
    }
}
