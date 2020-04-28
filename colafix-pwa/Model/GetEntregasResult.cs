using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public partial class GetEntregasResult
    {
        [JsonProperty("GetEntregasResult")]
        public GetEntregasResultData GetEntregasResultData { get; set; }
    }

    public class GetEntregasResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public List<Entrega> Entregas { get; set; }
    }

    public partial class GetEntregasResult
    {
        public static GetEntregasResult FromJson(string json) => JsonConvert.DeserializeObject<GetEntregasResult>(json, Converter.Settings);
    }
}
