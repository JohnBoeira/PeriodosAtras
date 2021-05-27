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
              
            int anos = ConverterAno(date);
            int dias = ConverterDias(date);
            int meses = ConverterMeses(date);

            dias = Math.Abs(dias);
            meses = Math.Abs(meses);

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
                else if(dias != 0) { 
                    dataConvertida += "e "+ conversorDia.Converter(dias.ToString()); 
                }
                
            }
            else if (meses != 0) //tem mes
            {              
                dataConvertida += ConverterMeses(meses, dias); 
            }
            else if(dias != 0)   
            {
                dataConvertida += conversorDia.Converter(dias.ToString());
            }
            else
            {
                int horas = DateTime.Now.Hour - date.Hour;
                int min = DateTime.Now.Minute - date.Minute;
                int segundos = DateTime.Now.Second - date.Second;

                dataConvertida += conversorHoraMinSec.Converter(horas.ToString(), min.ToString(), segundos.ToString());
            }
            return deixarPrimeiraLetraUpper(dataConvertida) + "atrás";
        }

        private string ConverterMeses(int meses, int dias)
        {
            string mesConvertido = null;

            mesConvertido += conversorMes.Converter(meses.ToString());
            if (dias !=  0) //tem dia
            {
                if (dias > 7)//tem semana
                {
                    mesConvertido += conversorDia.Converter(dias.ToString());
                }
                else
                {
                    mesConvertido += "e " + conversorDia.Converter(dias.ToString());
                }
            }
                       
            return mesConvertido;
        }

        private int ConverterAno(DateTime date)
        {   
            TimeSpan span = DateTime.Today - date;
   
            return (DateTime.MinValue + span).Year - 1;
        }

        private int ConverterMeses(DateTime date)
        {
            TimeSpan span = DateTime.Today - date;

            return (DateTime.MinValue + span).Month - 1;
        }


        private int ConverterDias(DateTime date)
        {
            TimeSpan span = DateTime.Today - date;

            return (DateTime.MinValue + span).Day - 1;
        }
        private string deixarPrimeiraLetraUpper(string dataConvertida)
        {
            return char.ToUpper(dataConvertida[0]) + dataConvertida.Substring(1);
        }
    }
}
