namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e sou um professor com um salário de R${Salario}.");
        }
    }
}