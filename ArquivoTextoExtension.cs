using System.Text;

namespace MV.Extensions
{
    public static class ArquivoTextoExtension
    {
        private static readonly object locker = new object();

        public static string CriarArquivoTexto(string caminho, string nomeArquivo)
        {
            if (string.IsNullOrWhiteSpace(caminho))
                throw new ArgumentException("O caminho não pode ser vazio.", nameof(caminho));

            if (string.IsNullOrWhiteSpace(nomeArquivo))
                throw new ArgumentException("O nome do arquivo não pode ser vazio.", nameof(nomeArquivo));

            string caminhoCompleto = Path.Combine(caminho, nomeArquivo);

            // Garante que o diretório existe
            string diretorio = Path.GetDirectoryName(caminhoCompleto);
            if (!string.IsNullOrEmpty(diretorio) && !Directory.Exists(diretorio))
                Directory.CreateDirectory(diretorio);

            // Cria o arquivo vazio
            using (File.Create(caminhoCompleto)) { }

            return caminhoCompleto;
        }

        public static bool ArquivoExiste(string caminhoCompleto)
        {
            return !string.IsNullOrWhiteSpace(caminhoCompleto) && File.Exists(caminhoCompleto);
        }

        public static string LerArquivo(string caminhoCompleto, Encoding encoding = null)
        {
            if (string.IsNullOrWhiteSpace(caminhoCompleto))
                throw new ArgumentException("O caminho do arquivo não pode ser vazio.", nameof(caminhoCompleto));

            if (!File.Exists(caminhoCompleto))
                throw new FileNotFoundException("O arquivo não foi encontrado.", caminhoCompleto);

            encoding = encoding ?? Encoding.UTF8;

            return File.ReadAllText(caminhoCompleto, encoding);
        }

        public static void AdicionaTexto(string caminhoCompleto, string texto, Encoding encoding = null)
        {
            if (string.IsNullOrWhiteSpace(caminhoCompleto))
                throw new ArgumentException("O caminho do arquivo não pode ser vazio.", nameof(caminhoCompleto));

            if (!File.Exists(caminhoCompleto))
                throw new FileNotFoundException("O arquivo não foi encontrado.", caminhoCompleto);

            if (texto == null)
                texto = string.Empty;

            encoding = encoding ?? Encoding.UTF8;

            lock (locker)
            {
                File.AppendAllText(caminhoCompleto, texto, encoding);
            }
        }

        public static void AdicionaLinha(string caminhoCompleto, string linha, Encoding encoding = null)
        {
            AdicionaTexto(caminhoCompleto, linha + Environment.NewLine, encoding);
        }
    }
}
