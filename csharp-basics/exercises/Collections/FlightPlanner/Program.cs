using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = @"C:\Users\37123\Desktop\C-sharp-syllabus_2\csharp-basics\exercises\Collections\FlightPlanner\flights.txt";

        private static void Main(string[] args)
        {
            var _text = new List<string>(File.ReadAllLines(Path));
            var city_one = new HashSet<string>();
            var city_two = new HashSet<string>();

            foreach (var s in _text)
            {
                var p = s.Split('-');
                city_one.Add(p[0]);
            }
            foreach (var s in _text)
            {
                var p = s.Split('-');
                p[1] = p[1].Replace(">", "");
                city_two.Add(p[1]);
            }

            Console.WriteLine("What would you like to do? :");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");

            var input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (input)
            {
                case '1':
                    foreach (var s in city_one)
                    {
                        Console.WriteLine(s);
                    }

                    Console.WriteLine("To select a city from which you would like to start");
                    var print = Console.ReadLine();
                    var start_First_Country = print;
                    foreach (var s in _text)
                    {
                        var p = s.Split('-');
                        p[0] = p[0].Replace(">", "");
                        if (p[0].Contains(print))
                        {
                            Console.WriteLine(s);
                        }
                    }

                    print = string.Empty;
                    while(start_First_Country != print)
                    {
                        Console.WriteLine("What would you like to do:");
                        Console.WriteLine("To display list of the cities press 1");
                        Console.WriteLine("Select a city press 2");
                        Console.WriteLine("If you want to leave the progrmm press 3");
                        input = Console.ReadKey().KeyChar;
                        Console.WriteLine();

                        if (input == 1)
                        {
                            Console.WriteLine("Good news! All fights is available");
                            foreach (var s in _text)
                            {
                                Console.WriteLine(s);
                            }
                        }
                        else if (input == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Select a city");

                            foreach (var s in city_one)
                            {
                                Console.WriteLine(s);
                            }
                            print = Console.ReadLine();
                            foreach (var s in _text)
                            {
                                var p = s.Split('-');
                                p[0] = p[0].Replace(">", "");
                                if (p[0].Contains(print))
                                {
                                    Console.WriteLine(s);
                                }
                            }

                            Console.WriteLine();
                            Console.WriteLine("Select a city you want to travel");
                            print = Console.ReadLine();
                            foreach (var s in _text)
                            {
                                var p = s.Split('-');
                                p[1] = p[1].Replace(">", "");
                                if (p[0].Contains(print))
                                {
                                    Console.WriteLine(s);
                                }
                            }
                        }
                        else break;
                    }
                    break;
                case '#':
                    break;
            }
        }
    }
}
