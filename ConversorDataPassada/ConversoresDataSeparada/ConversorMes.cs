using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDataPassada.ConversoresDataSeparada
{
    public class ConversorMes : ConversorNumerico
    {
        public string Converter(string meses)
        {
            if (ConverterValor(meses) == "um")
            {
                return ConverterValor(meses) + " mês ";
            }
            else
            {
                return ConverterValor(meses) + " meses ";
            }
        }
    }
}
