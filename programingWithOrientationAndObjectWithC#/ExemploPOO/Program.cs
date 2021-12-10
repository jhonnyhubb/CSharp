using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Computador comp = new Computador();
            System.Console.WriteLine(comp.ToString());
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
