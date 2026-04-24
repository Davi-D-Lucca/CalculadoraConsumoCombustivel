using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace CalculadoraConsumoCombustivel.DTO
{
    public class PostoDTO
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("cnpj")]
        public string Cnpj { get; set; }

        [JsonPropertyName("razao_social")]
        public string RazaoSocial { get; set; }

        [JsonPropertyName("fantasia")]
        public string Fantasia { get; set; }

        [JsonPropertyName("cep")]
        public string Cep { get; set; }

        [JsonPropertyName("endereco")]
        public string Endereco { get; set; }

        [JsonPropertyName("endereco_numero")]
        public string EnderecoNumero { get; set; }

        [JsonPropertyName("complemento")]
        public string Complemento { get; set; }

        [JsonPropertyName("cidade")]
        public string Cidade { get; set; }

        [JsonPropertyName("uf")]
        public string Uf { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("data_coleta")]
        public DateTime DataColeta { get; set; }

        [JsonPropertyName("bandeira")]
        public string Bandeira { get; set; }

        [JsonPropertyName("preco_venda")]
        public decimal PrecoVenda { get; set; }

        [JsonPropertyName("dados_api")]
        public string DadosApi { get; set; }
    }
}
