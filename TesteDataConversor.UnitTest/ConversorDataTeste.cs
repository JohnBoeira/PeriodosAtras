using ConversorDataPassada;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TesteDataConversor.UnitTest
{
    [TestClass]
    public class ConversorDataTeste
    {
        [TestMethod]
        public void Conversor_Dia()
        {
            ConversorData conversorData = new ConversorData();
            //HH:mm:ss
            string resultado = conversorData.Converter(Convert.ToDateTime("25/05/2021"));
            string resultado1 = conversorData.Converter(Convert.ToDateTime("24/05/2021"));
            Assert.AreEqual("Um dia atrás", resultado);
            Assert.AreEqual("Dois dias atrás", resultado1);
        }
        [TestMethod]
        public void Conversor_Semana()
        {
            ConversorData conversorData = new ConversorData();
            //HH:mm:ss
            string resultado = conversorData.Converter(Convert.ToDateTime("19/05/2021"));
            string resultado1 = conversorData.Converter(Convert.ToDateTime("12/05/2021"));

            Assert.AreEqual("Uma semana atrás", resultado);
            Assert.AreEqual("Duas semanas atrás", resultado1);
        }
        [TestMethod]
        public void Conversor_Mes()
        {
            ConversorData conversorData = new ConversorData();
            //HH:mm:ss
            string resultado = conversorData.Converter(Convert.ToDateTime("26/04/2021"));

            Assert.AreEqual("Um mês atrás", resultado);

        }
        [TestMethod]
        public void Conversor_Ano()
        {
            ConversorData conversorData = new ConversorData();
            //HH:mm:ss
            string resultado = conversorData.Converter(Convert.ToDateTime("26/05/2020"));
         
            Assert.AreEqual("Um ano atrás", resultado);
        
        }
        [TestMethod]
        public void Conversor_AnoMesDia()
        {
            ConversorData conversorData = new ConversorData();
            //HH:mm:ss
            string resultado = conversorData.Converter(Convert.ToDateTime("19/03/2020"));

            Assert.AreEqual("Um ano dois meses e uma semana atrás", resultado);

        }
    }
}

