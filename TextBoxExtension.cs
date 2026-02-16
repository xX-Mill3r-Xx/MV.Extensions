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

        public static int SomenteInteiros(int numero)
        {
            return numero;
        }

        public static decimal SomenteDecimais(decimal numeroDecimal)
        {
            return numeroDecimal;
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
