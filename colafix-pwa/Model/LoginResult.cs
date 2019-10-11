using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public partial class LoginResult
    {
        [JsonProperty("LoginResult")]
        public LoginResultClass LoginResultLoginResult { get; set; }
    }

    public class LoginResultClass
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("data")]
        public LogedUser Data { get; set; }
    }

    public partial class LoginResult
    {
        public static LoginResult FromJson(string json) => JsonConvert.DeserializeObject<LoginResult>(json, Converter.Settings);
    }
}
