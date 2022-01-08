using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "..//..//flights.txt";

        private static void Main(string[] args)
        {
            string[] AllText = File.ReadAllLines(Path);
            List<string> tripAvailable = AllText.ToList();

            char programIsWorking = '+';
            char choice;
            do
            {
                Console.WriteLine("To display list of available trips press 1");
                Console.WriteLine("To start your trip press 2");
                Console.WriteLine("To exit program press #");

                choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case '1':
                        Console.WriteLine("This is list of available flights: ");
                        Console.WriteLine(string.Join("\n", tripAvailable));
                        break;
                    case '2':
                        bool fly = true;
                        int timeToFlight = 0;
                        List<string> cities = new List<string>();
                        Console.WriteLine("From which city would you like to start? San Jose, New York, Anchorage, Honolulu, Denver, San Francisco");
                        string city = Console.ReadLine();
                        cities.Add(city);
                        while (fly)
                        {
                            Console.WriteLine(FligthPlannerProgram.Trip(city, cities));
                            Console.Write("Where will you to fly next? ");
                            city = Console.ReadLine();
                            FligthPlannerProgram.checkAvailable(city, timeToFlight, tripAvailable, cities);
                            fly = FligthPlannerProgram.RoundTrip(city, cities);
                            timeToFlight++;
                        }

                        Console.WriteLine("Your route was " + string.Join(" -> ", cities));
                        break;
                    default:
                        Console.WriteLine("Error.Try again!");
                        break;
                }
            } while (programIsWorking != choice);
        }
    }

    public class FligthPlannerProgram
    {
        public static string Trip(string city, List<string> cities)
        {
            string tripDestinatinChoice = string.Empty;
            string sanJose = "San Jose";
            string newYork = "New York";
            string anchorage = "Anchorage";
            string honolulu = "Honolulu";
            string denver = "Denver";
            string sanFrancisco = "San Francisco";

            if (city == sanJose)
                tripDestinatinChoice = "You can fly from " + city + " to " + sanFrancisco + " or " + anchorage;
            else if (city == newYork)
                tripDestinatinChoice = "You can fly from " + city + " to " + anchorage + ", " + sanJose + ", " + sanFrancisco + ", " + honolulu;
            else if (city == anchorage)
                tripDestinatinChoice = "You can fly from " + city + " to " + newYork + " or " + sanJose;
            else if (city == honolulu)
                tripDestinatinChoice = "You can fly from " + city + " to " + newYork + " or " + sanFrancisco;
            else if (city == denver)
                tripDestinatinChoice = "You can fly from " + city + " to " + sanJose;
            else if (city == sanFrancisco)
                tripDestinatinChoice = "You can fly from " + city + " to " + newYork + ", " + honolulu + ", " + denver;
            else
                throw new ArgumentException("Error,try again");

            return tripDestinatinChoice;
        }

        public static List<string> checkAvailable(string city, int flyingTimes, List<string> flightsAvailable, List<string> cities)
        {
            if (!flightsAvailable.Contains(cities[flyingTimes] + " -> " + city))
                throw new ArgumentException("Not avaliable trip from " + cities[flyingTimes] + " to " + city);
            else
                cities.Add(city);

            return cities;
        }

        public static bool RoundTrip(string city, List<string> cities)
        {
            bool fly = true;
            if (cities[0] == city)
                fly = false;

            return fly;
        }
    }
}
