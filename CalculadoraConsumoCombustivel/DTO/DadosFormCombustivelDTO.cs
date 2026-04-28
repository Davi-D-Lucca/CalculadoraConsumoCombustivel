using CalculadoraConsumoCombustivel.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsumoCombustivel.DTO
{
    class DadosFormCombustivelDTO
    {
        public DadosFormCombustivelDTO(string veiculo, string combustivel, int quantidade, int consumoMedio, string distanciaPercorrida)
        {
            Veiculo = veiculo;
            //Combustivel = combustivel;
            Quantidade = quantidade;
            ConsumoMedio = consumoMedio;
            DistanciaPercorrida = distanciaPercorrida;
        }

        public string Veiculo { get; set; }
        public TipoCombustivel Combustivel { get; set; }
        public int Quantidade { get; set; }
        public int ConsumoMedio { get; set; }
        public string DistanciaPercorrida { get; set; }

        public bool IsValid()
        {
            return false;
        }

        private TipoCombustivel SelecionarCombustivel(string combustivel)
        {
            switch (combustivel)
            {
                case "Gasolina":
                    return TipoCombustivel.Gasolina;
                case "Etanol":
                    return TipoCombustivel.Etanol;
                case "Diesel":
                    return TipoCombustivel.Diesel;
                default:
                    throw new InvalidOperationException("Não foi possivel identificar o tipo de combustivel");
            }

           
        }
    }
}
