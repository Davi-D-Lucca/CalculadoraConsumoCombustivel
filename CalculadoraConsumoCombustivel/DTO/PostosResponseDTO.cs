using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace CalculadoraConsumoCombustivel.DTO
{

    public class PostosResponseDTO
    {
        [JsonPropertyName("postos")]
        public List<PostoDTO> Postos { get; set; }
    }
}
