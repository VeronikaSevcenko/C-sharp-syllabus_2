using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };
            
            Console.Write("List before sort: ");
            Console.WriteLine(string.Join(",", colors));

            foreach (var a in colors)
            {
                Console.WriteLine(a);
            }

            colors.Sort();

            Console.Write("List after sort: ");
            Console.WriteLine(string.Join(",", colors));

            foreach (var b in colors)
            {
                Console.WriteLine(b);
            }
        }
    }
}
