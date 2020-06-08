using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public partial class UpdateSituacaoPedidoAppResult
    {
        [JsonProperty("UpdateSituacaoPedidoAppResult")]
        public UpdateSituacaoPedidoAppResultData UpdateSituacaoPedidoAppResultData { get; set; }
    }

    public class UpdateSituacaoPedidoAppResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public string PedidoApp { get; set; }
    }

    public partial class UpdateSituacaoPedidoAppResult
    {
        public static UpdateSituacaoPedidoAppResult FromJson(string json) => JsonConvert.DeserializeObject<UpdateSituacaoPedidoAppResult>(json, Converter.Settings);
    }
}
