using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class Credential
    {
        [JsonProperty("senha")]
        public string Senha { get; set; }

        [JsonProperty("usuario")]
        public string Usuario { get; set; }
    }
}
