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
            string resultado = conversorData.Converter(Convert.ToDateTime("26/05/2021"));
            string resultado1 = conversorData.Converter(Convert.ToDateTime("28/05/2020"));
            Assert.AreEqual("Um dia atrás", resultado);
            Assert.AreEqual("Onze meses quatro semanas e trinta dias atrás", resultado1);
        }
        [TestMethod]
        public void Conversor_Semana()
        {
            ConversorData conversorData = new ConversorData();
            //HH:mm:ss
            string resultado = conversorData.Converter(Convert.ToDateTime("20/05/2021"));
            string resultado1 = conversorData.Converter(Convert.ToDateTime("13/05/2021"));

            Assert.AreEqual("Uma semana atrás", resultado);
            Assert.AreEqual("Duas semanas atrás", resultado1);
        }
        [TestMethod]
        public void Conversor_Mes()
        {
            ConversorData conversorData = new ConversorData();
            //HH:mm:ss
            string resultado = conversorData.Converter(Convert.ToDateTime("26/04/2021"));
            string resultado1 = conversorData.Converter(Convert.ToDateTime("27/12/2020"));

            Assert.AreEqual("Um mês atrás", resultado);
            Assert.AreEqual("Cinco meses atrás", resultado1);
        }
        [TestMethod]
        public void Conversor_Ano()
        {
            ConversorData conversorData = new ConversorData();
            //HH:mm:ss
            string resultado = conversorData.Converter(Convert.ToDateTime("27/05/2020"));

            Assert.AreEqual("Um ano atrás", resultado);

        }
        [TestMethod]
        public void Conversor_AnoMesDia()
        {
            ConversorData conversorData = new ConversorData();
            //HH:mm:ss
            string resultado = conversorData.Converter(Convert.ToDateTime("20/03/2020"));

            Assert.AreEqual("Um ano dois meses uma semana e nove dias atrás", resultado);

        }
        [TestMethod]
        public void Conversor_HorasSegMinutos()
        {
            ConversorHoraMinSec conversorHoraMinSec = new ConversorHoraMinSec();
            DateTime dataAntiga = Convert.ToDateTime("27/03/2020 20:10:10");
            DateTime dataNova = Convert.ToDateTime("27/03/2020 22:10:10");

            //act
            int horas = dataNova.Hour - dataAntiga.Hour;
            int min = dataNova.Minute - dataAntiga.Minute;
            int segundos = dataNova.Second - dataAntiga.Second;

            string resultado = conversorHoraMinSec.Converter(horas.ToString(), min.ToString(), segundos.ToString()) + "atrás";

            Assert.AreEqual("duas horas atrás", resultado);

            dataAntiga = Convert.ToDateTime("27/03/2020 20:10:10");
            dataNova = Convert.ToDateTime("27/03/2020 22:11:11");
            horas = dataNova.Hour - dataAntiga.Hour;
            min = dataNova.Minute - dataAntiga.Minute;
            segundos = dataNova.Second - dataAntiga.Second;

            resultado = conversorHoraMinSec.Converter(horas.ToString(), min.ToString(), segundos.ToString()) + "atrás";
            Assert.AreEqual("duas horas um minuto e um segundo atrás", resultado);

            dataAntiga = Convert.ToDateTime("27/03/2020 20:10:10");
            dataNova = Convert.ToDateTime("27/03/2020 22:31:10");
            horas = dataNova.Hour - dataAntiga.Hour;
            min = dataNova.Minute - dataAntiga.Minute;
            segundos = dataNova.Second - dataAntiga.Second;

            resultado = conversorHoraMinSec.Converter(horas.ToString(), min.ToString(), segundos.ToString()) + "atrás";
            Assert.AreEqual("duas horas vinte e um minutos atrás", resultado);
        }
    }
}

