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

