using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDataPassada
{
    public class ConversorHoraMinSec : ConversorNumerico
    {
        public string Converter(string horas, string min, string seg)
        {
            string horasMinSecExtenso = null;
            if (horas == "1")
            {
                horasMinSecExtenso += "uma hora ";
                horasMinSecExtenso += ConverterMinESeg(min, seg);
            }
            else if (horas == "2")
            {
                horasMinSecExtenso += "duas horas ";
                horasMinSecExtenso += ConverterMinESeg(min, seg);
            }
            else
            {
                horasMinSecExtenso += ConverterValor(horas) + " horas ";
                horasMinSecExtenso += ConverterMinESeg(min, seg);
            }
            return horasMinSecExtenso;
        }

        #region metodos privados
        private string ConverterMinESeg(string min, string seg)
        {
            if (min == "0")
            {
                if (seg != "0")
                {
                    return " e " + ConverterSegApenas(seg);
                }
                return "";
            }
            if (min == "1")
            {
                if (seg != "0")
                {
                    return "um minuto" + " e " + ConverterSegApenas(seg);
                }
                else
                {
                    return "um minuto ";
                }

            }
            else
            {
                if (seg != "0")
                {
                    return ConverterValor(min) + " minutos "+ " e " + ConverterValor(seg);
                }
                else
                {
                    return ConverterValor(min) + " minutos ";
                }
            }
        }

        private string ConverterSegApenas(string seg)
        {
            if (seg == "0")
            {
                return "";
            }
            if (seg == "1")
            {
                return "um segundo ";
            }
            else
            {
                return ConverterValor(seg) + " segundos ";
            }
        }
        #endregion 
    }
}
