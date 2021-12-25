using System;

namespace RollTwoDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum;
            Random rnd = new Random();
            int desired1 = rnd.Next(7);
            int desired2 = rnd.Next(7);
            int SumOfTheTwoDice = desired1 + desired2;
            int count = 0;

            Console.WriteLine("What amount do you want?");
            Sum = int.Parse(Console.ReadLine());
            Console.WriteLine(desired1 + " and " + desired2 + " = " + SumOfTheTwoDice);

            while (SumOfTheTwoDice != Sum)
            {
                desired1 = rnd.Next(7);
                desired2 = rnd.Next(7);
                SumOfTheTwoDice = desired1 + desired2;
                count++;
                Console.WriteLine(desired1 + " and " + desired2 + " = " + SumOfTheTwoDice);
            }
        }
    }
}
