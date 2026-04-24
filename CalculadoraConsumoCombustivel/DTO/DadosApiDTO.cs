using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace CalculadoraConsumoCombustivel.DTO
{
    public class DadosApiDTO
    {
        [JsonPropertyName("uf")]
        public string Uf { get; set; }

        [JsonPropertyName("cep")]
        public string Cep { get; set; }

        [JsonPropertyName("cnpj")]
        public string Cnpj { get; set; }

        [JsonPropertyName("razao_social")]
        public string RazaoSocial { get; set; }

        [JsonPropertyName("nome_fantasia")]
        public string NomeFantasia { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("numero")]
        public string Numero { get; set; }

        [JsonPropertyName("municipio")]
        public string Municipio { get; set; }

        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("porte")]
        public string Porte { get; set; }

        [JsonPropertyName("capital_social")]
        public decimal CapitalSocial { get; set; }

        [JsonPropertyName("cnae_fiscal")]
        public int CnaeFiscal { get; set; }

        [JsonPropertyName("cnae_fiscal_descricao")]
        public string CnaeFiscalDescricao { get; set; }

        [JsonPropertyName("natureza_juridica")]
        public string NaturezaJuridica { get; set; }

        [JsonPropertyName("situacao_cadastral")]
        public int SituacaoCadastral { get; set; }

        [JsonPropertyName("descricao_situacao_cadastral")]
        public string DescricaoSituacaoCadastral { get; set; }

        [JsonPropertyName("data_inicio_atividade")]
        public DateTime DataInicioAtividade { get; set; }

        [JsonPropertyName("data_situacao_cadastral")]
        public DateTime DataSituacaoCadastral { get; set; }

        [JsonPropertyName("qsa")]
        public List<SocioDTO> Qsa { get; set; }

        [JsonPropertyName("cnaes_secundarios")]
        public List<CnaeSecundarioDTO> CnaesSecundarios { get; set; }

        [JsonPropertyName("regime_tributario")]
        public List<RegimeTributarioDTO> RegimeTributario { get; set; }
    }
}
