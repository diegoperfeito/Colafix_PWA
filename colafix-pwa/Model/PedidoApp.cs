using Newtonsoft.Json;
using System.Collections.Generic;

namespace colafix_pwa.Model
{
    public class PedidoApp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("data_emissao")]
        public string DataEmissao { get; set; }

        [JsonProperty("cod_ven")]
        public string CodVen { get; set; }

        [JsonProperty("cod_cli")]
        public string CodCli { get; set; }

        [JsonProperty("nome_cli")]
        public string NomeCli { get; set; }

        [JsonProperty("nome_loc_cob")]
        public string NomeLocCob { get; set; }

        [JsonProperty("nome_transa")]
        public string NomeTransa { get; set; }

        [JsonProperty("cod_emp")]
        public string CodEmp { get; set; }

        [JsonProperty("cod_emp_fat")]
        public string CodEmpFat { get; set; }

        [JsonProperty("cod_loc_cob")]
        public string CodLocCob { get; set; }

        [JsonProperty("cod_nat_oper")]
        public string CodNatOper { get; set; }

        [JsonProperty("cod_transa")]
        public string CodTransa { get; set; }

        [JsonProperty("cod_transp")]
        public string CodTransp { get; set; }

        [JsonProperty("diap1")]
        public string Diap1 { get; set; }

        [JsonProperty("diap2")]
        public string Diap2 { get; set; }

        [JsonProperty("diap3")]
        public string Diap3 { get; set; }

        [JsonProperty("diap4")]
        public string Diap4 { get; set; }

        [JsonProperty("diap5")]
        public string Diap5 { get; set; }

        [JsonProperty("diap6")]
        public string Diap6 { get; set; }

        [JsonProperty("diap7")]
        public string Diap7 { get; set; }

        [JsonProperty("diap8")]
        public string Diap8 { get; set; }

        [JsonProperty("diap9")]
        public string Diap9 { get; set; }

        [JsonProperty("diap10")]
        public string Diap10 { get; set; }

        [JsonProperty("embalagem")]
        public string Embalagem { get; set; }

        [JsonProperty("obs")]
        public string Obs { get; set; }

        [JsonProperty("perc_acrescimo")]
        public long PercAcrescimo { get; set; }

        [JsonProperty("perc_desc")]
        public long PercDesc { get; set; }

        [JsonProperty("peso_bru")]
        public long PesoBru { get; set; }

        [JsonProperty("peso_liq")]
        public long PesoLiq { get; set; }

        [JsonProperty("situacao")]
        public string Situacao { get; set; }

        [JsonProperty("tipo_frete")]
        public long TipoFrete { get; set; }

        [JsonProperty("total_frete")]
        public long TotalFrete { get; set; }

        [JsonProperty("usu_altera")]
        public string UsuAltera { get; set; }

        [JsonProperty("usu_inclui")]
        public string UsuInclui { get; set; }

        [JsonProperty("vlr_merc")]
        public long VlrMerc { get; set; }

        [JsonProperty("vlr_tot")]
        public long VlrTot { get; set; }

        [JsonProperty("vlr_acrescimo")]
        public long VlrAcrescimo { get; set; }

        [JsonProperty("vlr_desc")]
        public long VlrDesc { get; set; }

        [JsonProperty("vlr_frete")]
        public long VlrFrete { get; set; }

        [JsonProperty("vlr_icms")]
        public long VlrIcms { get; set; }

        [JsonProperty("vlr_icms_st")]
        public long VlrIcmsSt { get; set; }

        [JsonProperty("vlr_ipi")]
        public long VlrIpi { get; set; }

        [JsonProperty("pedido_item_app")]
        public List<PedidoItemApp> PedidoItemApp { get; set; }
    }

    public class PedidoItemApp
    {
        [JsonProperty("cod_prod")]
        public string CodProd { get; set; }

        [JsonProperty("nome_prod")]
        public string NomeProd { get; set; }

        [JsonProperty("ind_comissao")]
        public long IndComissao { get; set; }

        [JsonProperty("ind_custo")]
        public long IndCusto { get; set; }

        [JsonProperty("ind_financeiro")]
        public long IndFinanceiro { get; set; }

        [JsonProperty("ind_frete")]
        public long IndFrete { get; set; }

        [JsonProperty("ind_geral")]
        public long IndGeral { get; set; }

        [JsonProperty("ind_impostos")]
        public long IndImpostos { get; set; }

        [JsonProperty("item")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Item { get; set; }

        [JsonProperty("obs")]
        public string Obs { get; set; }

        [JsonProperty("perc_desconto")]
        public long PercDesconto { get; set; }

        [JsonProperty("perc_icms")]
        public long PercIcms { get; set; }

        [JsonProperty("perc_ipi")]
        public long PercIpi { get; set; }

        [JsonProperty("peso_bru_un")]
        public long PesoBruUn { get; set; }

        [JsonProperty("peso_liq_un")]
        public long PesoLiqUn { get; set; }

        [JsonProperty("qtde_ped")]
        public long QtdePed { get; set; }

        [JsonProperty("qtde_emb")]
        public long QtdeEmb { get; set; }

        [JsonProperty("situacao")]
        public string Situacao { get; set; }

        [JsonProperty("valor")]
        public decimal Valor { get; set; }

        [JsonProperty("valor_fabrica")]
        public long ValorFabrica { get; set; }

        [JsonProperty("valor_indice")]
        public long ValorIndice { get; set; }
    }

    public class Pedidos
    {
    }



}