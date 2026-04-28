using CalculadoraConsumoCombustivel.Application;
using CalculadoraConsumoCombustivel.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CalculadoraConsumoCombustivel.teste
{
    [TestClass]
    public class AggregateStrategyTeste
    {
        [TestMethod]
        public void TesteAgregação()
        {
            var aplication = new ConsultaListaPosto();
            var diesel = aplication.ConsultaPostosDiesel().Result;
            var etanol = aplication.ConsultaPostosEtanol().Result;
            var gasolina = aplication.ConsultaPostosGasolina().Result;
            //Feita para ser substituida mais facil no futuro
            IAggregateStrategy strategy = new AggregateStrategy(diesel, etanol, gasolina);
            //Da para instanciar mais de 1 vez a interface com classe diferente para fazer comparações

            //var agrupado = strategy.AgruparPorPosto();
            var result = strategy.Start();



            //Teste para gerar um arquivo TXT
            var conteudo = string.Join(Environment.NewLine,
                result.Select(p =>
                    $"{p.RazaoSocial}" + Environment.NewLine +
                    string.Join(Environment.NewLine, p.Combustiveis.Select(c =>
                        $"   - {c.Combustivel}: {c.Preco}"
                    ))
                )
            );
            File.WriteAllText(@"C:\Users\davidlucca\Documents\testeCombustivel\resultado.txt", conteudo);

        }
    }
}
