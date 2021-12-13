using System;//FEITO
class DIO
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); 
        if( n > 5 && n < 2000)
        {
            int quadradoPares = 0;       
            for(int i = 1; (2*i) <= n; i++ )
            {
                quadradoPares = (2*i)*(2*i);
                Console.WriteLine($"{2*i}^2 = {quadradoPares}");
            }
        }
    }
}