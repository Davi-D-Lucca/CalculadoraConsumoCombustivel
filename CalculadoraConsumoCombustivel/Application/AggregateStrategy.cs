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
        //Com _
        private readonly PostosResponseDTO _diesel;
        private readonly PostosResponseDTO _etanol;
        private readonly PostosResponseDTO _gasolina;
        //readonly nunca vai mudar, vai diminuir o peso cognitivo do desenvolvedor
        //Do inicio ao fim, não vai modificar a variavel

        public AggregateStrategy(PostosResponseDTO diesel, PostosResponseDTO etanol, PostosResponseDTO gasolina)
        {
            _diesel = diesel;
            _etanol = etanol;
            _gasolina = gasolina;
        }

        public List<PostoDTO> Start() 
        {

            return null;
        }
    }
}
