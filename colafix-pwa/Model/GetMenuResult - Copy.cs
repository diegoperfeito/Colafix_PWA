using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public partial class GetMenuResult
    {
        [JsonProperty("GetMenuResult")]
        public GetMenuResultData GetMenuResultData { get; set; }
    }

    public class GetMenuResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public List<ProductGroup> ProductGroup { get; set; }
    }

    public partial class GetMenuResult
    {
        public static GetMenuResult FromJson(string json) => JsonConvert.DeserializeObject<GetMenuResult>(json, Converter.Settings);
    }
}
