using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int Sum = 0;

            Console.WriteLine("Enter a single digit number");
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                Sum += n % 10;
                n /= 10;

                Console.WriteLine("Sum of all the numbers: " + Sum);
                Console.ReadLine();
            }
        }
    }
}
