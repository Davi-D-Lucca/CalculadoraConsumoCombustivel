
using CalculadoraConsumoCombustivel.Infra.Entidades.Base;
using CalculadoraConsumoCombustivel.Infra.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsumoCombustivel.Infra.Entidades
{
    public class MediaConsumoCombustivel : Entidade
    {
        public string Veiculo { get; set; }
        public TipoCombustivel Combustivel { get; set; }
        public int Quantidade { get; set; }
        public int ConsumoMedio { get; set; }
        public string DistanciaPercorrida { get; set; }
    }
}
