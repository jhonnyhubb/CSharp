using System;
using ExemploPOO.Helpers;
using ExemploPOO.Models;
using ExemploPOO.Models.Interfaces;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
             
            var caminho = "D:\\Users\\Jonas\\Documents\\programação\\Desenvolvedor-Back-End\\C#";
            var caminhoArquivo = Path.Combine(caminho, "arquivo2.txt");
            var novoCaminho = Path.Combine(caminho, "pasta2", "arquivo2.txt");
            var caminhoDiretorio = Path.Combine(caminho, "pasta2");
            var listaString = new List<string> {"linha 1", "linha 2", "linha 3", "linha 4"};
            var listaString1 = new List<string> {"linha 5", "linha 6", "linha 7", "linha 8"};
            
            FileHelper helper = new FileHelper();

            helper.DeletarArquivo(caminhoArquivo);
            helper.DeletarArquivo(novoCaminho);
            Directory.Delete(caminhoDiretorio);

            // helper.CopiarArquivo(novoCaminho, caminhoArquivo, false);

            // helper.CriarDiretorio(novoCaminho);
            // helper.MoverArquivo(caminhoArquivo, novoCaminho);

            // helper.LerArquivoStream(caminhoArquivo);

            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaString1);

            // helper.CriarArquivoTexto(caminhoArquivo, "oi estou testando a criação de um arquivo texto");

            // helper.ApagarDiretorio(caminhoPathCombine, true);
            // System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            

            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Multiplicar(10,20));

            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar( 2, 3));

            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar( 2, 3, 13));

            // Aluno p1 = new Aluno();
            
            // p1.Nome = "Bob";
            // p1.Idade = 23;
            // p1.Documento = "1234586";
            // p1.Nota = 7;   
            // p1.Apresentar(); 

            // Professor p2 = new Professor();
            
            // p2.Nome = "Bob";
            // p2.Idade = 23;
            // p2.Documento = "1234586";
            // p2.Salario = 3522;   
            // p2.Apresentar();   

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "João";
            // p1.Idade = 23;

            // p1.Apresentar();
            
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas (30, 20);
                
            // System.Console.WriteLine($"Área: {r.ObterArea()}");
        }
    }
}
