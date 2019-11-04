using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class Empresa
    {
        [JsonProperty("codEmp")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CodEmp { get; set; }

        [JsonProperty("nomeEmp")]
        public string NomeEmp { get; set; }

        [JsonProperty("unidade")]
        public object Unidade { get; set; }

        [JsonProperty("usuario")]
        public string Usuario { get; set; }
    }
}
