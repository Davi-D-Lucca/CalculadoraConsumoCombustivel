using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CalculadoraConsumoCombustivel.DTO
{
    public class RegimeTributarioDTO
    {
        [JsonPropertyName("ano")]
        public int Ano { get; set; }

        [JsonPropertyName("forma_de_tributacao")]
        public string FormaDeTributacao { get; set; }

        [JsonPropertyName("quantidade_de_escrituracoes")]
        public int QuantidadeDeEscrituracoes { get; set; }
    }
}
