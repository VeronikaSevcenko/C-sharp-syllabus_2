using System;

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
            
            int z = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < 20; i++)
            {
                if (numbers[i] == z)
                {
                    Console.Write(i + ",");
                }
            }
        }
    }
}
