using System;
class DIO //FEITO
{
    static void Main(string[] args)
    {
        double Sum = 0;
        double i = 1;
        while(i <= 100)
        {
            Sum += 1/i;
            i++;
        }
        var value = Math.Round(Sum,2);
        Console.WriteLine(value);
        }
}