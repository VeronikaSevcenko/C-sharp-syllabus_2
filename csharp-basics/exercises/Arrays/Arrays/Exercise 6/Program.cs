using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[array1.Length];
            Random r = new Random();

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = r.Next(10);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array1[i];
            }
            array1[9] = -7;
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Array 1:" + array1[i]);
            }
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Array 2: " + array2[i]);
            }
        }
    }
}
