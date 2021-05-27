using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDataPassada
{
    public class ConversorNumerico
    {
        public string ConverterValor(string valor)
        {          
            switch (valor.Length)
            {              
                case 1: return ConverterUnidade(valor.ToCharArray()[0]);
                case 2: return ConverterDezenaUnidade(valor.ToCharArray()[1], valor.ToCharArray()[0]);
                case 3: return ConverterCentenaDezenaUni(valor.ToCharArray()[2], valor.ToCharArray()[1], valor.ToCharArray()[0]);              
            }
            return "";
        }

        private string ConverterUnidade(char unidade)
        {
            switch (unidade)
            {
                case'0': return "";
                case'1': return "um";
                case'2': return "dois";
                case'3': return "três";
                case'4': return "quatro";
                case'5': return "cinco";
                case'6': return "seis";
                case'7': return "sete";
                case'8': return "oito";
                case'9': return "nove";
                default: throw new ArgumentOutOfRangeException("Valor digitado incorreto: ", nameof(unidade));
            }
        }

        protected string ConverterDezenaUnidade(char dezena, char unidade)
        {          
            if (dezena == 1)
            {
                switch (unidade)
                {
                    case'0': return "dez";
                    case'1': return "onze";
                    case'2': return "doze";
                    case'3': return "treze";
                    case'4': return "quatorze";
                    case'5': return "quinze";
                    case'6': return "dezesseis";
                    case'7': return "dezessete";
                    case'8': return "dezoito";
                    case'9': return "dezenove";
                    default: throw new ArgumentOutOfRangeException("Valor digitado incorreto: ", nameof(dezena), nameof(unidade));
                }
            }
            else
            {
                if (unidade == 0) //ex: 20 30 40 50 80
                {
                    return ConverterDezena(dezena);
                }
                else //ex: 21
                {
                    return ConverterDezena(dezena) + " e " + ConverterUnidade(unidade);
                }
            }

        }

        private string ConverterDezena(char dezena)
        {
            switch (dezena)
            {         
                case'2': return "vinte";
                case'3': return "trinta";
                case'4': return "quarenta";
                case'5': return "cinquenta";
                case'6': return "sessenta";
                case'7': return "setenta";
                case'8': return "oitenta";
                case'9': return "noventa";
                default: throw new ArgumentOutOfRangeException("Valor digitado incorreto: ", nameof(dezena));
            }
        }
        protected string ConverterCentenaDezenaUni(char centena, char dezena, char unidade) //001 000
        {
            if (centena == '1' && unidade == '0' && dezena == '0')
            {
                return "cem";
            }
            else if (unidade == '0' && dezena == '0')
            {
                return ConverterCentena(centena);
            }           
            else
            {
                return ConverterCentena(centena) + " e " + ConverterDezenaUnidade(unidade, dezena);
            }
        }

        protected string ConverterCentena(int centena)
        {
            switch (centena)
            {
                case'0': return "";
                case'1': return "cento";
                case'2': return "duzentos";
                case'3': return "trezentos";
                case'4': return "quatrocentos";
                case'5': return "quinhentos";
                case'6': return "seiscentos";
                case'7': return "setecentos";
                case'8': return "oitocentos";
                case'9': return "novecentos";
                default: throw new ArgumentOutOfRangeException("Valor digitado incorreto: ", nameof(centena));
            }
        }
    }
}
