using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class Transacao
    {
        [JsonProperty("codTran")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CodTran { get; set; }

        [JsonProperty("geraTit")]
        public object GeraTit { get; set; }

        [JsonProperty("natOper")]
        public string NatOper { get; set; }

        [JsonProperty("natOperServ")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long NatOperServ { get; set; }

        [JsonProperty("nomeTran")]
        public string NomeTran { get; set; }

        [JsonProperty("percDifIcms")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PercDifIcms { get; set; }

        [JsonProperty("situacao")]
        public object Situacao { get; set; }

        [JsonProperty("substTrib")]
        public string SubstTrib { get; set; }

        [JsonProperty("tipo")]
        public string Tipo { get; set; }

        [JsonProperty("tipoOper")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long TipoOper { get; set; }

        [JsonProperty("tribIcmsDentro")]
        public string TribIcmsDentro { get; set; }

        [JsonProperty("tribIcmsFora")]
        public object TribIcmsFora { get; set; }

        [JsonProperty("tribIpi")]
        public string TribIpi { get; set; }

        [JsonProperty("tributIcms")]
        public string TributIcms { get; set; }

        [JsonProperty("tributIcmsCsosn")]
        public object TributIcmsCsosn { get; set; }
    }
}
