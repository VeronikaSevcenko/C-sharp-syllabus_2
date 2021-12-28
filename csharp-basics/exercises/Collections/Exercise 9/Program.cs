using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vs = new HashSet<string>
            {
                "Alex",
                "Martin",
                "Gloria",
                "Melman",
                "Julien",
                "Alex"
            };

            Console.WriteLine("5 string values to HashSet: ");

            foreach (var s in vs)
            {
                Console.WriteLine(s);
            }
            
            Console.WriteLine();

            vs.Clear();
            Console.WriteLine("After removing: ");

            foreach (var s in vs)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine("Can't to add duplicated values");
        }
    }
}
