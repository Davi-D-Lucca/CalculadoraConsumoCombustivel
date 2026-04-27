using CalculadoraConsumoCombustivel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsumoCombustivel.Interfaces
{
    public interface IAggregateStrategy
    {
        //Lista e um metodo
        List<PostoDTO> Start();
     
    }
}
