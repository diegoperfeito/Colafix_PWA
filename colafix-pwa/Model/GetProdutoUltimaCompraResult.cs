using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public partial class GetProdutoUltimaCompraResult
    {
        [JsonProperty("GetProdutoUltimaCompraResult")]
        public GetProdutoUltimaCompraResultData GetProdutoUltimaCompraResultData { get; set; }
    }

    public class GetProdutoUltimaCompraResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public ProdutoUltimaCompra ProdutoUltimaCompra { get; set; }
    }

    public partial class GetProdutoUltimaCompraResult
    {
        public static GetProdutoUltimaCompraResult FromJson(string json) => JsonConvert.DeserializeObject<GetProdutoUltimaCompraResult>(json, Converter.Settings);
    }
}
