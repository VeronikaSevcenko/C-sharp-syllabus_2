using System;

namespace Exercise_8
{
    static class Constant
    {
        public const int sizeF = 7;
        public const int sizeT = 5;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = Constant.sizeF;
            int a = Constant.sizeT;

            for (int x = 1; x <= n; x++)
            {
                for (int j = 1; j <= 28 - 4 * x; j++)
                {
                    Console.Write("/");
                }
                for (int j = 1; j <= 8 * x - 8; j++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= 28 - 4 * x; j++)
                {
                    Console.Write("\\");
                }
                Console.WriteLine();
            }

            for (int z = 1; z <= a; z++)
            {
                for (int j = 1; j <= 20 - 4 * z; j++)
                {
                    Console.Write("/");
                }
                for (int j = 1; j <= 8 * z - 8; j++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= 20 - 4 * z; j++)
                {
                    Console.Write("\\");
                }
                Console.WriteLine();
            }
        }
    }
}
