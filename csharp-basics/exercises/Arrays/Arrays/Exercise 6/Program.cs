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
            int[] Array1 = new int[10];
            int[] Array2 = new int[Array1.Length];
            Random r = new Random();

            for (int i = 0; i < Array1.Length; i++)
            {
                Array1[i] = r.Next(10);
            }
            for (int i = 0; i < Array2.Length; i++)
            {
                Array2[i] = Array1[i];
            }
            Array1[9] = -7;
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.WriteLine("Array 1:" + Array1[i]);
            }
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.WriteLine("Array 2: " + Array2[i]);
            }
        }
    }
}
