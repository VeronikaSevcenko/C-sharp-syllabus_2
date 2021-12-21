using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Brown",
            };

            var secondList = new List<string>
            {
                "Yellow",
                "Purpule",
                "Pink",
                "Lime",
                "Rose",
            };

            var newList = firstList.Union(secondList);

            Console.Write(string.Join(",", newList));

            Console.ReadKey();
        }
    }
}
