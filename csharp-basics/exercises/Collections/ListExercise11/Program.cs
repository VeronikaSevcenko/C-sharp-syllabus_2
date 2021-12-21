using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var emotions = new List<string>
            {
                "Smile",
                "Loving",
                "Happiness",
                "Anger",
                "Hesitant",
                "Glad",
                "Joyful",
                "Upset",
                "Frustrated",
                "Playful",
            };
            emotions.Insert(5, "Angry");

            Console.WriteLine(string.Join(",", emotions));
            Console.WriteLine();

            int index = emotions.FindIndex(s => s == "Playful");
            if (index != -1)
            {
                emotions[index] = "Delighed";
            }
            Console.WriteLine(string.Join(",", emotions));
            Console.WriteLine();

            var lastItem = emotions.Last();

            Console.Write("Last position :" + " " + lastItem);
            Console.WriteLine();

            Console.WriteLine("List in alphabetical order : ");
            emotions.Sort();
            for (int i = 0; i < emotions.Count; i++)
            {
                Console.WriteLine("\t"+emotions[i]);
            }

            Console.WriteLine("My list contains word 'Foobar' ?");
            Console.WriteLine(emotions.Contains("White"));
            Console.WriteLine();

            Console.WriteLine("Print each element of list using loop: ");

            foreach (var emotion in emotions)
            {
                Console.WriteLine("\t{0}",emotion);
            }
        }
    }
}
