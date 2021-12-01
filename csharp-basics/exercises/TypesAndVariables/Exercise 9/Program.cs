using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour;
            double minutes;
            double seconds;
            double distance;

            double TimeSec;
            double MetrsPerSeconds;
            double KilometrPerHour;
            double MilesPerHour;

            Console.WriteLine("Enter distance in meters:");
            distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the hour");
            hour = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the minutes");
            minutes = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seconds");
            seconds = double.Parse(Console.ReadLine());

            TimeSec = (hour * 3600) + (minutes * 60) + seconds;
            MetrsPerSeconds = distance / TimeSec;
            KilometrPerHour = (distance / 1000.0f) / (TimeSec / 3600.0f);
            MilesPerHour = KilometrPerHour / 1.609f; 

            Console.WriteLine("Your speed in meters/second is" + MetrsPerSeconds);
            Console.WriteLine("Your speed in km/h is" + KilometrPerHour);
            Console.WriteLine("our speed in miles/h is" + MilesPerHour);
        }
    }
}
