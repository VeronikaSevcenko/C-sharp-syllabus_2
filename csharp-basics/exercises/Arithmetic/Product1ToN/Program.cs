using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 1;
            for (int i = 1; i <= 10; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);

        }
    }
}
