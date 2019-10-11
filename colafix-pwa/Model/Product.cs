using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class Product
    {
        [JsonProperty("codProd")]
        public string CodProd { get; set; }

        [JsonProperty("custoFat")]
        public string CustoFat { get; set; }

        [JsonProperty("custoRep")]
        public string CustoRep { get; set; }

        [JsonProperty("embalagem")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Embalagem { get; set; }

        [JsonProperty("grupo")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Grupo { get; set; }

        [JsonProperty("imagem")]
        public string Imagem { get; set; }

        [JsonProperty("inativo")]
        public Enums.Inativo Inativo { get; set; }

        [JsonProperty("multiploApontamento")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long MultiploApontamento { get; set; }

        [JsonProperty("nomeProd")]
        public string NomeProd { get; set; }

        [JsonProperty("percIpi")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PercIpi { get; set; }

        [JsonProperty("percRedbaseicms")]
        public string PercRedbaseicms { get; set; }

        [JsonProperty("pesoBru")]
        public string PesoBru { get; set; }

        [JsonProperty("pesoLiq")]
        public string PesoLiq { get; set; }

        [JsonProperty("subGrupo")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SubGrupo { get; set; }

        [JsonProperty("unidade")]
        public Enums.Unidade Unidade { get; set; }
    }
}
