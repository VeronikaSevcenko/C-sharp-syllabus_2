using System;
using System.Linq;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter single numbers series an between number please put ',' For example:9,3 or 5,3,1 ");

            string numbers = Console.ReadLine();
            
            int[] converted = numbers.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            Console.WriteLine();

            int Sum = converted.Sum();
            Console.WriteLine("The sum of all the numbers is : {0}", Sum);
        }
    }
}
