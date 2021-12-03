using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Onomatopoeia", "Quinoa", "Mischievous", "logorrhea" };
            var rnd = new Random();
            var word = words[rnd.Next (0, words.Length)];
            var guessable = new string('_', word.Length);
            var misses = string.Empty;

            while (guessable.IndexOf('_') != -1) 
            {
                Console.WriteLine($"word: {guessable}");
                Console.WriteLine($"Misses: {misses}");

                var input = Console.ReadKey();
                var guess = input.KeyChar;
                
                Console.WriteLine();
                Console.WriteLine($"Guess: {guess}");

                if (word.IndexOf(guess) > -1)
                {
                    for (var i = 0; i < word.Length; i++)
                    {
                        if (word.ToLower()[i] == guess)
                        {
                            var sb = new StringBuilder(guessable);
                            sb[i] = word[i];
                            guessable = sb.ToString();
                        }
                    }
                }
                else
                {
                    misses += guess;
                }
                Console.ReadKey();
            }
        }
    }
}
