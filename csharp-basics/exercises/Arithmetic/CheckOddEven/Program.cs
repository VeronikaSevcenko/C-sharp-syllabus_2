using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Even Number");
                Console.WriteLine("Bye");
            }
            else
            {
                Console.WriteLine("Odd Number");
                Console.WriteLine("Bye");

                Console.ReadKey();
            }
        }
    }
    public class CheckOddNumber
    {
        public static bool IsOddNumber(int a)
        {
            return a % 2 == 1;
        }
    }
}