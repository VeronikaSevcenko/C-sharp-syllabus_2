using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[50];
            Random rnd = new Random();
            Console.WriteLine("Random numbers: ");
            Console.WriteLine();

            for (int i = 0; i < 20; i++)
            {
                int result = rnd.Next(50);
                numbers[i] = result;
                Console.Write(numbers[i] + "  ");
            }

            Console.WriteLine();
            Console.WriteLine("Which index  of number you want to know?");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(Array.IndexOf(numbers, input));
        }
    }
}
