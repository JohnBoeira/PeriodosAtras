using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDataPassada
{
    public class ConversorAno : ConversorNumerico
    {
        public string Converter(string anos)
        {
            if (ConverterValor(anos) =="um")
            {
                return ConverterValor(anos) + " ano ";
            }
            else
            {
                return ConverterValor(anos) + " anos ";
            }            
        }

    }
}
