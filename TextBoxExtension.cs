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
    }
}
