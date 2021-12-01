using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("First integer");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Second integer");
            b = int.Parse(Console.ReadLine());

            bool result = a == 15 || b == 15 || a + b == 15 || Math.Abs(a - b) == 15;

            Console.WriteLine(result);

        }
    }
}