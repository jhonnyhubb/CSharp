namespace ExemploPOO.Models
{
    public class Aluno : Pessoa //aluno herda de Pessoa
    {
        public int Nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e sou um aluno de nota {Nota}.");
        }
    }
}