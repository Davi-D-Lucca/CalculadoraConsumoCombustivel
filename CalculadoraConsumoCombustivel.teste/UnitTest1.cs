using CalculadoraConsumoCombustivel.Application;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculadoraConsumoCombustivel.teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRetornaPosto()
        {
            //Red Gren Refactor
            //TDD
            //Teste unidade, linhas de codigo no testeclasse para testar o codigo no projeto metodos
            var aplication = new ConsultaListaPosto();
            var result = aplication.ConsultaPostosDiesel().Result;




        }
    }
}
