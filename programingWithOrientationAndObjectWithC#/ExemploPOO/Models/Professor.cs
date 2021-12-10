namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e sou um professor com um salário de R${Salario}.");
        }
    }
}