namespace ExemploPOO.Helpers
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetFiles(caminho, "*", SearchOption.TopDirectoryOnly);
            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void ListarArquivosDiretorio(string caminho)
        {
            var retornoCaminho = Directory.GetFiles(caminho, "*2.txt", SearchOption.AllDirectories);
            foreach(var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }
        public void ApagarDiretorio(string caminho, bool ApagarArquivos)
        {
            Directory.Delete(caminho, ApagarArquivos);
        }

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if(File.Exists(conteudo))
            {
                File.WriteAllText(caminho, conteudo); // não irá sobrescrever o arquivo
            }
        }
        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho))
            {
                foreach(var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }
        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }
        public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText(caminho))
            {
                foreach(var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }
        public void LerArquivo (string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach(var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }
        public void LerArquivoStream(string caminho) //recomendado para arquivos grandes
        {
            string linha = string.Empty;

            using (var stream = File.OpenText(caminho))
            {
                while((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }
        public void MoverArquivo(string caminho, string novoCaminho)
        {
            File.Move(caminho, novoCaminho);
        }
        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Copy(caminho, novoCaminho, sobrescrever); //vai sobrescrever o arquivo
        }
        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}