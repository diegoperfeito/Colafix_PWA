using Newtonsoft.Json;
using System.Collections.Generic;

namespace colafix_pwa.Model
{
    public class Financeiro
    {
        [JsonProperty("totalAVencer")]
        public string TotalAVencer { get; set; }

        [JsonProperty("totalEmAberto")]
        public string TotalEmAberto { get; set; }

        [JsonProperty("totalEmAbertoCartorio")]
        public string TotalEmAbertoCartorio { get; set; }

        [JsonProperty("totalEmAbertoProtesto")]
        public string TotalEmAbertoProtesto { get; set; }

        [JsonProperty("totalLimiteDisponivel")]
        public string TotalLimiteDisponivel { get; set; }

        [JsonProperty("totalVencido")]
        public string TotalVencido { get; set; }

        [JsonProperty("valorLimite")]
        public string ValorLimite { get; set; }

        [JsonProperty("financeirotitulo")]
        public List<FinanceiroTitulo> FinanceiroTitulo { get; set; }

    }

    public class FinanceiroTitulo
    {
        [JsonProperty("codCliFor")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CodCliFor { get; set; }

        [JsonProperty("codEmp")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CodEmp { get; set; }

        [JsonProperty("codTit")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CodTit { get; set; }

        [JsonProperty("desdTit")]
        public string DesdTit { get; set; }

        [JsonProperty("dtVencim")]
        public string DtVencim { get; set; }

        [JsonProperty("dtVencimFormatado")]
        public string DtVencimFormatado { get; set; }


        [JsonProperty("nomeCliFor")]
        public string NomeCliFor { get; set; }

        [JsonProperty("obsFin")]
        public string ObsFin { get; set; }

        [JsonProperty("saldo")]
        public string Saldo { get; set; }

        [JsonProperty("saldoFormatado")]
        public string SaldoFormatado { get; set; }
    }

}