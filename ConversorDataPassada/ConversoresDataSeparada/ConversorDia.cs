using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDataPassada
{
    public class ConversorDia : ConversorNumerico
    {
        private int diasDescontadoDaSemana;
        private int quantidadeDeSemanas;
        public string Converter(string dia)
        {
            string diasExtenso = null;
            diasDescontadoDaSemana = Convert.ToInt32(dia);
            ContarSemanas(Convert.ToInt32(dia));
            if (quantidadeDeSemanas != 0)
            {
                if (quantidadeDeSemanas == 1)
                {
                    diasExtenso += "uma semana ";
                    if (diasDescontadoDaSemana != 0)
                    {
                        diasExtenso += "e " + ConverterApenasDia(dia);
                    }
                }
                else if (quantidadeDeSemanas == 2)
                {
                    diasExtenso += "duas semanas ";
                    if (diasDescontadoDaSemana != 0)
                    {
                        diasExtenso += "e " + ConverterApenasDia(dia);
                    }
                }
                else
                {
                    diasExtenso += ConverterValor(quantidadeDeSemanas.ToString()) + " semanas ";
                    if (diasDescontadoDaSemana != 0)
                    {
                        diasExtenso += "e " + ConverterApenasDia(dia);
                    }                   
                }                
            }
            else
            {
                diasExtenso += ConverterApenasDia(dia);
            }
            return diasExtenso;
        }

        private string ConverterApenasDia(string dia)
        {
            if (ConverterValor(dia) == "um")
            {
                return ConverterValor(dia) + " dia ";
            }
            else
            {
                return ConverterValor(dia) + " dias ";
            }
        }

        private void ContarSemanas(int dia)
        {
            int contadorDeSemanas = 0;
            for (int i = 1; i < dia +1; i++)
            {
                if (i % 7 == 0)
                {
                    contadorDeSemanas++;
                    diasDescontadoDaSemana -= 7;
                }
            }
            quantidadeDeSemanas = contadorDeSemanas;
        }
              
    }
}
