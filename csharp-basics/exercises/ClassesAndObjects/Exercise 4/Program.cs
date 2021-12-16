using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var SpiderMan = new Movie("Spider-Man", "Columbia Pictures", "PG");
            var CasinoRoyal = new Movie("Casino Royale", "Eon Productions", "PG13");
            var Glass = new Movie("Glass", "Buena Vista International", "PG13");
            var movies = new List<Movie>
            {
                SpiderMan,
                CasinoRoyal,
                Glass
            };
            var filtred = GetPG(movies.ToArray());
            foreach (var movie in filtred)
            {
                Console.WriteLine($"{movie}");
                Console.WriteLine($"{movie.Display()}");
            }
        }

        public static Movie[] GetPG(Movie[] movies)
        {
            var filtred = new List<Movie>();
            foreach (var movie in movies)
            {
                if(movie.Rating == "PG")
                {
                    filtred.Add(movie);
                }
            }
            return filtred.ToArray();
        }
    }
}
