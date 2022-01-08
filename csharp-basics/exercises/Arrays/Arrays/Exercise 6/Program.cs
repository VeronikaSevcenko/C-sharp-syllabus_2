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

            int max = 100;
            int min = 1;
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            Random r = new Random();

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = r.Next(10);
                Console.WriteLine("Array 1:" + array1[i]);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array1[i];
                Console.WriteLine("Array 2: " + array2[i]);
            }
            LastNumbers.ChangeLastNumber(min, max, array1, array2);
        }
    }
    
    public class LastNumbers
    {
        public static void ChangeLastNumber(int min, int max, int[] array1, int[] array2)
        {
            Random r = new Random();

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = r.Next(min, max);
                array2[i] = array1[i];
            }
            array1[array1.Length - 1] = -7;
        }
    }
}
