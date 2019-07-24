using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;   
namespace CalculadoraService.Test
{
    [TestClass]
    public class CalculadoraServiceTest
    {
        [DataTestMethod]
        [DataRow(3,3,6)]
        [DataRow(3,4,7)]
        [DataRow(3,5,8)]
        [DataRow(3,6,9)]
        [DataRow(3,7,10)]
        [DataRow(3,8,11)]
        [DataRow(2,3,5)]
        [DataRow(1,3,4)]
        [DataRow(0,3,12)]
        public void suma_valoresCorrectos_ok(int? numeroUno,int? numeroDos,int? resultadoEsperado)
        {
           //arrange
           

           var CalculadoraServiceUno = new CalculadoraService();

           //act
           
            int? resultado=CalculadoraServiceUno.suma(numeroUno,numeroDos);

           //assert

            Assert.AreEqual(resultado,resultadoEsperado);

        }


[TestMethod]
[ExpectedException (typeof(ArgumentNullException))]
 public void suma_valoresNulos_NullException()
        {
           //arrange
           

           var CalculadoraServiceUno = new CalculadoraService();

           //act
           
            int? resultado=CalculadoraServiceUno.suma(null,66);

           //assert

            //Assert.AreEqual(resultado,resultadoEsperado);

        }

    }
}
