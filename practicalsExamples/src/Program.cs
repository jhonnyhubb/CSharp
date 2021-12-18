using System;
using src.Entities;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", "warrior");
            Mage wedge = new Mage("Wedge", "Mage");

            System.Console.WriteLine(arus.Atack());
            System.Console.WriteLine(wedge.Atack(20));
        }
    }
}
