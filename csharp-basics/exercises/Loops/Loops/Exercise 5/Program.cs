using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            int i;

            Console.WriteLine("Enter first word: ");
            a = Console.ReadLine();

            Console.WriteLine("Enter second word: ");
            b = Console.ReadLine();

            var result = a + " " + b;
            var line = result.Length;
            int period = 0;

            if (line <= 30) period = 30 - line; 
            {
                var dot = "";

                for (i = 1; i <= period; i++) dot += ".";
                {
                    Console.WriteLine(a + dot + b);
                }
            }
        }
    }
}
