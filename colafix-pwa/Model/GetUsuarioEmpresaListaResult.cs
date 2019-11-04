using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public partial class GetUsuarioEmpresaListaResult
    {
        [JsonProperty("GetUsuarioEmpresaListaResult")]
        public GetUsuarioEmpresaListaResultData GetUsuarioEmpresaListaResultData { get; set; }
    }

    public class GetUsuarioEmpresaListaResultData
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public List<Empresa> Empresa { get; set; }
    }

    public partial class GetUsuarioEmpresaListaResult
    {
        public static GetUsuarioEmpresaListaResult FromJson(string json) => JsonConvert.DeserializeObject<GetUsuarioEmpresaListaResult>(json, Converter.Settings);
    }
}
