using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double minuteInTheYear = 60 * 24 * 365;
            double minute;

            Console.WriteLine("Write the number of minutes: ");
            minute = double.Parse(Console.ReadLine());

            long year = (long)(minute / minuteInTheYear);
            int days = (int)(minute / 60 / 24) % 365;

            Console.WriteLine(minute + " minutes is approximately " + year + " years and " + days + "days");
        }
    }
}
