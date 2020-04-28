using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class LogedUser
    {
        [JsonProperty("admin")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Admin { get; set; }

        [JsonProperty("cpfCnpj")]
        public string CpfCnpj { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("inativo")]
        public object Inativo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
//        [JsonConverter(typeof(ParseStringConverter))]
        public string Phone { get; set; }

        [JsonProperty("phoneCode")]
        public string PhoneCode { get; set; }

        [JsonProperty("senha")]
        public string Senha { get; set; }

        [JsonProperty("usuario")]
        public string Usuario { get; set; }
    }
}
