using CalculadoraConsumoCombustivel.DTO;
using System.Collections.Generic;

namespace CalculadoraConsumoCombustivel.Application
{
    public class PostoAgrupadoDTO
    {
        public string RazaoSocial { get; set; }
        public List<PostoResultadoDTO> Combustiveis { get; set; }
    }
}