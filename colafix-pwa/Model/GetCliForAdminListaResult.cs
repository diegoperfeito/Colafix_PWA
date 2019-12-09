using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class GetCliForAdminListaResult
    {
        [JsonProperty("GetCliForAdminListaResult")]
        public GetCliForAdminListaResultData GetCliForAdminListaResultData { get; set; }
    }

    public class GetCliForAdminListaResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public List<Cli> Clientes { get; set; }
    }
}
