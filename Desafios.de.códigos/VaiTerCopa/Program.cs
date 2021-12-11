using System;
class DIO//FEITO
{
    static void Main(string[] args)
    {
        string Reclamacoes;
        while ((Reclamacoes=Console.ReadLine())!= null)
        {
            int n = int.Parse(Reclamacoes);
            if(n == 0)
            {
                Console.WriteLine("vai ter copa!");
            }
            else
            {
                Console.WriteLine("vai ter duas!");
            }
        }
    }
}