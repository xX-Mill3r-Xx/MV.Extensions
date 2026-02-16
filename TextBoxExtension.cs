using System.Text.RegularExpressions;

namespace MV.Extensions
{
    public static class TextBoxExtension
    {
        public static string SomenteCaixaAlta(string texto)
        {
            return string.IsNullOrEmpty(texto) ? texto : texto.ToUpper();
        }

        public static string SomenteCaixaBaixa(string texto)
        {
            return string.IsNullOrEmpty(texto) ? texto : texto.ToLower();
        }

        public static string SomenteInteiros(string numero)
        {
            if(string.IsNullOrEmpty(numero))
            return numero;

            return new string(numero.Where(char.IsDigit).ToArray());
        }

        public static string SomenteDecimais(string numeroDecimal)
        {
            if(string.IsNullOrEmpty(numeroDecimal))
            return numeroDecimal;

            bool separadorEncontrado = false;
            var sb = new System.Text.StringBuilder();

            foreach (var item in numeroDecimal)
            {
                if(char.IsDigit(item))
                    sb.Append(item);
                else if ((item == '.' || item == ',') && !separadorEncontrado)
                {
                    sb.Append(item);
                    separadorEncontrado = true;
                }
            }

            return sb.ToString();
        }

        public static string RemoverAcentos(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            var normalized = texto.Normalize(System.Text.NormalizationForm.FormD);
            var sb = new System.Text.StringBuilder();
            foreach (var item in normalized)
            {
                if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(item) != 
                    System.Globalization.UnicodeCategory.NonSpacingMark)
                    sb.Append(item);
            }

            return sb.ToString().Normalize(System.Text.NormalizationForm.FormC);
        }

        public static int SomentePositivos(int numero)
        {
            return numero < 0 ? 0 : numero;
        }

        public static decimal ArredondaPraCima(decimal valor)
        {
            return Math.Ceiling(valor);
        }

        public static decimal ArredondaPraBaixo(decimal valor)
        {
            return Math.Floor(valor);
        }
    }
}
