using Newtonsoft.Json;
using System.Collections.Generic;

namespace colafix_pwa.Model
{
    public class PedidoNovo
    {
        [JsonProperty("Criticas")]
        public Critica[] Criticas { get; set; }

        [JsonProperty("PedidoId")]
        public long PedidoId { get; set; }
        }

        public class Critica
        {
            [JsonProperty("Descricao")]
            public string Descricao { get; set; }

            [JsonProperty("Tipo")]
            public string Tipo { get; set; }
        }

    }