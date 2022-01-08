using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ListExercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };
            colors.Insert(1, "Pink");
            colors.Insert(3, "Lime");

            string element = (string)colors[1];
            Console.WriteLine("First element: " + element);

            element = (string)colors[3];
            Console.WriteLine("Third element: " + element);

        }
    }
}
