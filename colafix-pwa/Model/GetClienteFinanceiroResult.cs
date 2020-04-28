using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class GetClienteFinanceiroResult
    {
        [JsonProperty("GetClienteFinanceiroResult")]
        public GetClienteFinanceiroResultData GetClienteFinanceiroResultData { get; set; }
    }

    public class GetClienteFinanceiroResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public Financeiro Financeiro { get; set; }
    }
}
