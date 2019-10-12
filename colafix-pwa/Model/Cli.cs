using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class Cli
    {
        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("cep")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Cep { get; set; }

        [JsonProperty("cidade")]
        public string Cidade { get; set; }

        [JsonProperty("cliente")]
        public object Cliente { get; set; }

        [JsonProperty("codCidade")]
        public object CodCidade { get; set; }

        [JsonProperty("codEmpresa")]
        public object CodEmpresa { get; set; }

        [JsonProperty("codTransacao")]
        public object CodTransacao { get; set; }

        [JsonProperty("codVendedor")]
        public object CodVendedor { get; set; }

        [JsonProperty("contato")]
        public object Contato { get; set; }

        [JsonProperty("cpfCnpj")]
        public string CpfCnpj { get; set; }

        [JsonProperty("dddFax")]
        public object DddFax { get; set; }

        [JsonProperty("dddFone")]
        public object DddFone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("emailNfe")]
        public object EmailNfe { get; set; }

        [JsonProperty("endereco")]
        public string Endereco { get; set; }

        [JsonProperty("estado")]
        public Enums.Estado Estado { get; set; }

        [JsonProperty("fax")]
        public object Fax { get; set; }

        [JsonProperty("fone")]
        public string Fone { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("inativoCli")]
        public object InativoCli { get; set; }

        [JsonProperty("inativoVen")]
        public object InativoVen { get; set; }

        [JsonProperty("inscricaoEstadual")]
        public object InscricaoEstadual { get; set; }

        [JsonProperty("isentoSt")]
        public object IsentoSt { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("nomeFantasia")]
        public object NomeFantasia { get; set; }

        [JsonProperty("observacao")]
        public string Observacao { get; set; }

        [JsonProperty("observacaoFinanceira")]
        public string ObservacaoFinanceira { get; set; }

        [JsonProperty("pessoa")]
        public object Pessoa { get; set; }

        [JsonProperty("site")]
        public object Site { get; set; }

        [JsonProperty("usuario")]
        public object Usuario { get; set; }

        [JsonProperty("vendedor")]
        public object Vendedor { get; set; }

        [JsonProperty("vlrLimiteCredito")]
        public object VlrLimiteCredito { get; set; }
    }
}
