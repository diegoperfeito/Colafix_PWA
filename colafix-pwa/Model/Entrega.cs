using System.Collections.Generic;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class Entrega
    {
        [JsonProperty("cnpjEmitente")]
        public string CnpjEmitente { get; set; }

        [JsonProperty("dataEntrega")]
        public string DataEntrega { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("imgComprovante")]
        public object ImgComprovante { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("numeroNota")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long NumeroNota { get; set; }

        [JsonProperty("placaVeiculo")]
        public string PlacaVeiculo { get; set; }

        [JsonProperty("serieNota")]
        public string SerieNota { get; set; }

        [JsonProperty("dataCurta")]
        public string DataCurta { get; set; }

    }
}
