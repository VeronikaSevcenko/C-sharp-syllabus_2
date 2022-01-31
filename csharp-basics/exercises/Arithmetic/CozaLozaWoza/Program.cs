using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_6
{
    class CozaLW
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
    public class CozaLozaWoza
    {
        public string GetCozaLozaWoza()
        {
            var name = string.Empty;

            for (int i = 1; i <= 110; i++)
            {
                if (i % 3 == 0)
                {
                    name = name + "Coza";
                }
                else if (i % 5 == 0)
                {
                    name = name + "Loza";
                }
                else if (i % 7 == 0)
                {
                    name = name + "Woza";
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    name = name + "CozaLoza";
                }
                else
                {
                    name = name + (i + ((i - (1 - 1)) % 11 == 0 ? "\n" : " "));
                }
            }
            return name;
        }
    }
}
