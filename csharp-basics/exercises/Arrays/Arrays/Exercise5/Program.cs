using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        //TODO: Write a C# program to find the index of an array element.
        private static void Main(string[] args)
        {
            int[] myArray = {25, 14, 56, 15, 36, 56, 77, 18, 29, 49};

            var indexOfElement36 = 36;
            var indexOfElement29 = 29;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == indexOfElement36)
                {
                    indexOfElement36 = i;
                }
                if (myArray[i] == indexOfElement29)
                {
                    indexOfElement29 = i;
                }
            }
            Console.WriteLine("Index position of 36 is: " + indexOfElement36);
            Console.WriteLine("Index position of 29 is: " + indexOfElement29);
        }
    }
}
