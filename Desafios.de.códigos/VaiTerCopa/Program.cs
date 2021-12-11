// using System; 

// class DIO {

//     static void Main(string[] args) { 

//      string str;
//             while((str=Console.ReadLine())!= null)
//             {
//                 if (   )
//                 {
                       
//                 }
//                 else          //Escreva o seu código nos espaços em branco
//                 { 
//                     int x = int.Parse(str);
//                     if (         )
//                     {
//                     Console.WriteLine(   ); 
//                     }
//                     else
//                     {
//                         Console.WriteLine(  );
//                     }
//                 }
//             }

//     }

// }
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