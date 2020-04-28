using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public partial class UsuarioAtivoResult
    {
        [JsonProperty("UsuarioAtivoResult")]
        public UsuarioAtivoResultClass UsuarioAtivoResultUsuarioAtivoResult { get; set; }
    }

    public class UsuarioAtivoResultClass
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public LogedUser Data { get; set; }
    }

    public partial class UsuarioAtivoResult
    {
        public static UsuarioAtivoResult FromJson(string json) => JsonConvert.DeserializeObject<UsuarioAtivoResult>(json, Converter.Settings);
    }
}
