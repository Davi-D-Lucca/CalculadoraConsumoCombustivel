using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace CalculadoraConsumoCombustivel.DTO
{
    public class SocioDTO
    {
        [JsonPropertyName("nome_socio")]
        public string NomeSocio { get; set; }

        [JsonPropertyName("cnpj_cpf_do_socio")]
        public string Documento { get; set; }

        [JsonPropertyName("qualificacao_socio")]
        public string Qualificacao { get; set; }

        [JsonPropertyName("data_entrada_sociedade")]
        public DateTime DataEntrada { get; set; }

        [JsonPropertyName("nome_representante_legal")]
        public string Representante { get; set; }
    }
}
