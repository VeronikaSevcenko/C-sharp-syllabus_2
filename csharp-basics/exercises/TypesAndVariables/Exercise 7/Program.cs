using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;

            Console.WriteLine("Enter a string");
            sentence = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                    count++;
            }
            Console.WriteLine("Total number of characters in a string:" + count);
        }
    }
}
