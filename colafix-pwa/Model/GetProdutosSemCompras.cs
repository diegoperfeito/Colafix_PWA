using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public partial class GetProdutosSemComprasResult
    {
        [JsonProperty("GetProdutosSemCompraResult")]
        public GetProdutosSemComprasResultData GetProdutosSemComprasResultData { get; set; }
    }

    public class GetProdutosSemComprasResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public List<ProductGroup> ProductGroup { get; set; }
    }

    public partial class GetProdutosSemComprasResult
    {
        public static GetProdutosSemComprasResult FromJson(string json) => JsonConvert.DeserializeObject<GetProdutosSemComprasResult>(json, Converter.Settings);
    }
}
