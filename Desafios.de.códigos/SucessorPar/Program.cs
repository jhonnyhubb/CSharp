// using System; 

// class DIO {

//     static void Main(string[] args) { 

//     int x = int.Parse(Console.ReadLine());
            
//             //escreva aqui o seu código

//     }

// }
using System;
class DIO //FEITO
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        if(x % 2 == 1)
        {
            Console.WriteLine(++x);
        }
        else if(x % 2 == 0)
        {
            Console.WriteLine((x+2));
        }
    }
}