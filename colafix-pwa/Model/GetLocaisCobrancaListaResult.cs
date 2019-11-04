using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public partial class GetLocaisCobrancaListaResult
    {
        [JsonProperty("GetLocaisCobrancaListaResult")]
        public GetLocaisCobrancaListaResultData GetLocaisCobrancaListaResultData { get; set; }
    }

    public class GetLocaisCobrancaListaResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public List<LocalCobranca> LocalCobranca { get; set; }
    }

    public partial class GetLocaisCobrancaListaResult
    {
        public static GetLocaisCobrancaListaResult FromJson(string json) => JsonConvert.DeserializeObject<GetLocaisCobrancaListaResult>(json, Converter.Settings);
    }
}
