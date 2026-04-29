using CalculadoraConsumoCombustivel.Infra.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsumoCombustivel.DTO
{
    internal class CombustivelDTO
    {
        internal int Quantidade { get; set; }
        internal TipoCombustivel Combustivel { get; set; }

    }
}
