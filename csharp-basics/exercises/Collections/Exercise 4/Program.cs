using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            int number;
            int sum = 0;

            Console.WriteLine("Enter the number ");
            number = int.Parse(Console.ReadLine());

            while (sum != 1 && sum != 4)
            {
                sum = 0;
                while (number > 0)
                {
                    j = number % 10;
                    sum += (j * j);
                    number /= 10;
                }
                number = sum;
            }

            if (sum == 1)
            {
                Console.WriteLine("Happy number ");
            }
            else
            {
                Console.WriteLine("Unhappy number ");
            }
        }
    }
}
