using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public partial class UpdateClienteEmpilhadeiraResult
    {
        [JsonProperty("UpdateClienteEmpilhadeiraResult")]
        public UpdateClienteEmpilhadeiraResultData UpdateClienteEmpilhadeiraResultData { get; set; }
    }

    public class UpdateClienteEmpilhadeiraResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public string TemEmpilhadeira { get; set; }
    }

    public partial class UpdateClienteEmpilhadeiraResult
    {
        public static UpdateClienteEmpilhadeiraResult FromJson(string json) => JsonConvert.DeserializeObject<UpdateClienteEmpilhadeiraResult>(json, Converter.Settings);
    }
}
