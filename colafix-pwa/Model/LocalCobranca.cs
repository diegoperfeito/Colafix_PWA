using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class LocalCobranca
    {
        [JsonProperty("codLocCob")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CodLocCob { get; set; }

        [JsonProperty("mostraNoPedido")]
        public object MostraNoPedido { get; set; }

        [JsonProperty("nomeLocCob")]
        public string NomeLocCob { get; set; }
    }
}
