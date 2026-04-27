using CalculadoraConsumoCombustivel.Application;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculadoraConsumoCombustivel.teste
{
    [TestClass]
    public class ConsultaListaPostoTeste
    {
        [TestMethod]
        public void TestRetornaPostoDiesel()
        {
            //Red Gren Refactor
            //TDD
            //Teste unidade, linhas de codigo no testeclasse para testar o codigo no projeto metodos
            //Setup
            var aplication = new ConsultaListaPosto();
            //Action
            var result = aplication.ConsultaPostosDiesel().Result;
            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestRetornaPostoEtanol()
        {
            var aplication = new ConsultaListaPosto();
            var result = aplication.ConsultaPostosEtanol().Result;
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void TestRetornaPostoGasolina()
        {
            var aplication = new ConsultaListaPosto();
            var result = aplication.ConsultaPostosGasolina().Result;
            Assert.IsNotNull(result);
        }
    }
}
