using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public partial class GetTransacoesListaResult
    {
        [JsonProperty("GetTransacoesListaResult")]
        public GetTransacoesListaResultData GetTransacoesListaResultData { get; set; }
    }

    public class GetTransacoesListaResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public List<Transacao> Transacao { get; set; }
    }

    public partial class GetTransacoesListaResult
    {
        public static GetTransacoesListaResult FromJson(string json) => JsonConvert.DeserializeObject<GetTransacoesListaResult>(json, Converter.Settings);
    }
}
