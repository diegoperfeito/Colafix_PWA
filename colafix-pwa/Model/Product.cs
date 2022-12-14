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


    public class ProdutoUltimaCompra
    {
        [JsonProperty("codCli")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CodCli { get; set; }

        [JsonProperty("codProd")]
        public string CodProd { get; set; }

        [JsonProperty("codVend")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CodVend { get; set; }

        [JsonProperty("dataUltimaCompra")]
        public string DataUltimaCompra { get; set; }

        [JsonProperty("pedidoUltimaCompra")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PedidoUltimaCompra { get; set; }

        [JsonProperty("quantidadeUltimaCompra")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long QuantidadeUltimaCompra { get; set; }

        [JsonProperty("valorUltimaCompra")]
        public string ValorUltimaCompra { get; set; }
    }
}
