﻿// using System; 

// class DIO {

//     static void Main(string[] args) { 

//        for(           )
//             {
//                 for(        )    //escreva seu código nos espaços em branco
//                 {
//                     Console.WriteLine(       );
//                 }
//             }
//     }

// }

using System;
class DIO//FEITO
{
    static void Main(string[] args)
    {
        int i = 1;
        while(i <= 9)
        {
            for(int j = 7; j >= 5; j--)
            {
                Console.WriteLine($"I={i} J={j}");
            }
            i += 2;
        }
    }
}