using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public partial class GetProdutoResult
    {
        [JsonProperty("GetProdutoResult")]
        public GetProdutoResultData GetProdutoResultData { get; set; }
    }

    public class GetProdutoResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public Product Product { get; set; }
    }

    public partial class GetProdutoResult
    {
        public static GetProdutoResult FromJson(string json) => JsonConvert.DeserializeObject<GetProdutoResult>(json, Converter.Settings);
    }
}
