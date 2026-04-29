using CalculadoraConsumoCombustivel.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsumoCombustivel.DTO
{
    public class DadosFormCombustivelDTO
    {
        public DadosFormCombustivelDTO(string veiculo, string combustivel, string quantidade, string consumoMedio, string distanciaPercorrida)
        {
            Veiculo = veiculo;
            Combustivel = SelecionarCombustivel(combustivel);
            Quantidade = ConvertToInt(quantidade);
            ConsumoMedio = ConvertToInt(consumoMedio);
            DistanciaPercorrida = distanciaPercorrida;
        }

        public string Veiculo { get; set; }
        public TipoCombustivel Combustivel { get; set; }
        public int Quantidade { get; set; }
        public int ConsumoMedio { get; set; }
        public string DistanciaPercorrida { get; set; }

        public static bool validarForms(object posto, object combustivel, 
                string veiculo, string quantidadeC, string consumoC, string distanciaC)
        {

            bool postoSelecionado = posto != null;
            bool combustivelSelecionado = combustivel != null;
            bool textoVeiculo = TextoVazio(veiculo);
            bool quantidade = NumeroValido(quantidadeC);
            bool consumo = NumeroValido(consumoC);
            bool distancia = NumeroValido(distanciaC);

            return postoSelecionado && combustivelSelecionado && textoVeiculo && quantidade && consumo && distancia;
        }

        private int ConvertToInt(string text)
        {
            return Convert.ToInt32(text);
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

        public static bool TextoVazio(string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }

        public static bool NumeroValido(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            decimal res;
            if (!decimal.TryParse(text, out res))
                return false;

            if (res <= 0)
                return false;
            return true;
        }
    }
}
