using System;

namespace SadFor
{
    class Program
    {
        private static void Main(string[] args)
        {
            Test();
        }

        private static void Test()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if (Math.Sqrt(i) > 2.5)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}