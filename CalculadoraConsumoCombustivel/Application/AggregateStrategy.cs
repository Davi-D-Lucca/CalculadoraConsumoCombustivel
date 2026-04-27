using CalculadoraConsumoCombustivel.DTO;
using CalculadoraConsumoCombustivel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsumoCombustivel.Application
{
    public class AggregateStrategy : IAggregateStrategy
    {
        private readonly PostosResponseDTO diesel;
        private readonly PostosResponseDTO etanol;
        private readonly PostosResponseDTO gasolina;
        //readonly nunca vai mudar, vai diminuir o peso cognitivo do desenvolvedor
        //Do inicio ao fim, não vai modificar a variavel


        public AggregateStrategy(PostosResponseDTO diesel, PostosResponseDTO etanol, PostosResponseDTO gasolina)
        {

        }

        public List<PostoDTO> Start() 
        {
            return null;
        }
    }
}
