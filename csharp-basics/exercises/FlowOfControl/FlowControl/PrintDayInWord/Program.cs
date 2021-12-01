using System;

namespace PrintDayInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumer = int.Parse(Console.ReadLine());

            if (dayNumer == 1)
            {
                Console.WriteLine("Monday");
            }
            if (dayNumer == 2)
            {
                Console.WriteLine("Tuesday");
            }
            if (dayNumer == 3)
            {
                Console.WriteLine("Wednsday");
            }
            if (dayNumer == 4)
            {
                Console.WriteLine("Thursday");
            }
            if (dayNumer == 5)
            {
                Console.WriteLine("Friday");
            }
            if (dayNumer == 6)
            {
                Console.WriteLine("Saturday");
            }
            if (dayNumer == 7)
            {
                Console.WriteLine("Sunday");
            }
            if (dayNumer > 8)
            {
                Console.WriteLine("Not a valid day");
            }
        }
    }
}
