using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class GetCliForListaResult
    {
        [JsonProperty("GetCliForListaResult")]
        public GetCliForListaResultClass GetCliForListaResultGetCliForListaResult { get; set; }
    }

    public class GetCliForListaResultClass
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public List<Cli> Clientes { get; set; }
    }
}
