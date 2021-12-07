using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            Console.WriteLine("Hello! Whats your name?");
            myName = Console.ReadLine();
            Console.WriteLine("Well,let's play " + "" + myName + "," + "I'm thinking of a number between 1-100.  Try to guess it.");
            Random rnd = new Random();
            int numbers = rnd.Next(1, 100);
            int guess = 0;
            guess = int.Parse(Console.ReadLine());
            if (guess > numbers)
            {
                Console.WriteLine("Sorry, you are too high.  I was thinking of 51.");
            }
            else if (guess < numbers)
            {
                Console.WriteLine("Sorry, you are too low.  I was thinking of 34.");
            }
            else if (guess == numbers)
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }
        }
    }
}