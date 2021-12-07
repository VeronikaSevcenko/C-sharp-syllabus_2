using System;

namespace CozaLozaWoza
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 110; i++)
            {
                if (i % 3 == 0)
                {
                  Console.Write("Coza");
                }
                else if (i % 5 == 0)
                {
                  Console.Write("Loza");
                }
                else if (i % 7 == 0)
                {
                  Console.Write("Woza");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                  Console.Write("CozaLoza");
                }
                Console.Write(i + ((i - (1 - 1)) % 11 == 0 ? "\n" : " "));
        }   }
    }
}
