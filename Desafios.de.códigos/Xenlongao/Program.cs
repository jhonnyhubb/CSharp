/*
using System;
using System.Collections.Generic;
using System.Text;

namespace Dio
{
    class Xenlongao
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            while(N-- > 0)
            {
                int val =                                ;
                int newval =                         ;        //complete com a sua lógica
                int resposta =                      ;
                Console.WriteLine(resposta);
            }
        }
    }
}
*/
// using System;
// using System.Collections.Generic;
// using System.Text;

// namespace Dio
// {
//     class Xenlongao
//     {
//         static void Main(string[] args)
//         {
//             int esferas = 0;            
//             int c = int.Parse(Console.ReadLine());;//preciso aprender a colocar dados capturados em tamanho do array            
//             int i = 1;      
//             while( i <= c )
//             {
//                 int n = int.Parse(Console.ReadLine());//tenho que fazer ler mais de uma vez antes do laço 
//                 int j = 1;                
//                 while( j <= n)
//                 {  
//                     int divisivel = 0; 
//                     int k = 1; 
//                     while(k <= j)
//                     {                        
//                         if( j % k == 0)
//                         {
//                             divisivel++;
//                         }
//                         else{}
//                         k++;
//                     }
//                     if(divisivel % 2 == 0)
//                         {
//                             esferas++;
//                         }
//                     j++;    
//                 }
//                 Console.WriteLine(esferas);
//                 i++;
//             }
//         } 
//     }   
// }
using System;
namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      var C = int.Parse(Console.ReadLine());
      for (int i = 0; i < C; i++)
      {
        var esferas = int.Parse(Console.ReadLine());
        Console.WriteLine(esferas - Math.Floor(Math.Sqrt(esferas)));
      }
    }
  }
}

