using Newtonsoft.Json;
using System.Collections.Generic;

namespace colafix_pwa.Model
{
    public class PedidosRelatorio
    {
        [JsonProperty("cod_cli")]
        public string CodCli { get; set; }

        [JsonProperty("pedidos")]
        public List<PedidoApp> PedidosAapp { get; set; }

        [JsonProperty("total_analise")]
        public string TotalAnalise { get; set; }

        [JsonProperty("total_credito")]
        public string TotalCredito { get; set; }

        [JsonProperty("total_liquidado")]
        public string TotalLiquidado { get; set; }

        [JsonProperty("total_pendente")]
        public string TotalPendente { get; set; }

        [JsonProperty("total_reprovado")]
        public string TotalReprovado { get; set; }
    }
}