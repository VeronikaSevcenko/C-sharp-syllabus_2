using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Write a number");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz" + " ");
                }

                else if (i % 5 == 0)
                {
                    Console.Write("Buzz" + " ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz" + " ");
                }
                else
                {
                    Console.Write(i + " ");
                }

                if (i % 20 == 0)
                {
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
