using ConversorDataPassada.ConversoresDataSeparada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDataPassada
{
    public class ConversorData
    {
        ConversorDia conversorDia = new ConversorDia();
        ConversorAno conversorAno = new ConversorAno();
        ConversorMes conversorMes = new ConversorMes();
        ConversorHoraMinSec conversorHoraMinSec = new ConversorHoraMinSec();

        public string Converter(DateTime date)
        {
            string dataConvertida = null;
            int anos = DateTime.Now.Year - date.Year;
            int dias = DateTime.Now.Day - date.Day;
            int meses = DateTime.Now.Month - date.Month;

            if (anos != 0) // tem ano
            {
                dataConvertida += conversorAno.Converter(anos.ToString());
                if (meses != 0) //tem mes
                {   
                    if(dias != 0) { dataConvertida += ConverterMeses(meses, dias); }
                    else
                    {
                        dataConvertida += " e " + ConverterMeses(meses, dias);
                    }
                    
                }
            }
            else if (meses != 0) //tem mes
            {
                dataConvertida += ConverterMeses(meses, dias); ;
            }
            else if(dias != 0)   
            {
                dataConvertida += conversorDia.Converter(dias.ToString());
            }
            else
            {

            }
            return deixarPrimeiraLetraUpper(dataConvertida) + "atrás";
        }

        private string ConverterMeses(int meses, int dias)
        {
            string mesConvertido = null;

            mesConvertido += conversorMes.Converter(meses.ToString());
            if (dias !=  0) //tem dia
            {
                mesConvertido += "e " + conversorDia.Converter(dias.ToString());
            }
         
            return mesConvertido;
        }

        private string deixarPrimeiraLetraUpper(string dataConvertida)
        {
            return char.ToUpper(dataConvertida[0]) + dataConvertida.Substring(1);
        }
    }
}
