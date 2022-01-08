using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Histogram
{
    class Program
    {

        private const string Path = ("../../midtermscores.txt");

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);

            foreach (var p in readText)
            {
                Console.Write(p);
            }
            Console.WriteLine();

            List<List<string>> Histograma = new List<List<string>>();

            List<string> points00 = new List<string>();
            points00.Add("00-09:");
            List<string> points10 = new List<string>();
            points00.Add("10-19:");
            List<string> points20 = new List<string>();
            points00.Add("20-29:");
            List<string> points30 = new List<string>();
            points00.Add("30-39:");
            List<string> points40 = new List<string>();
            points00.Add("40-49:");
            List<string> points50 = new List<string>();
            points00.Add("50-59:");
            List<string> points60 = new List<string>();
            points00.Add("60-69:");
            List<string> points70 = new List<string>();
            points00.Add("70-79:");
            List<string> points80 = new List<string>();
            points00.Add("80-89:");
            List<string> points90 = new List<string>();
            points00.Add("90-99:");
            List<string> points100 = new List<string>();
            points00.Add("100: ");

            foreach (var input in readText)
            {
                string[] array = input.Split(' ');
                foreach (string line in array)
                {
                    int score = Convert.ToInt32(line);
                    if (score < 10)
                    {
                        points00.Add("*");
                    }
                    else if (score < 20 && score >= 10)
                    {
                        points10.Add("*");
                    }
                    else if (score < 30 && score >= 20)
                    {
                        points20.Add("*");
                    }
                    else if (score < 40 && score >= 30)
                    {
                        points30.Add("*");
                    }
                    else if (score < 50 && score >= 40)
                    {
                        points40.Add("*");
                    }
                    else if (score < 60 && score >= 50)
                    {
                        points50.Add("*");
                    }
                    else if (score < 70 && score >= 60)
                    {
                        points60.Add("*");
                    }
                    else if (score < 80 && score >= 70)
                    {
                        points70.Add("*");
                    }
                    else if (score < 90 && score >= 80)
                    {
                        points80.Add("*");
                    }
                    else if (score < 100 && score >= 90)
                    {
                        points90.Add("*");
                    }
                    else if (score <= 100)
                    {
                        points100.Add("*");
                    } 
                }

                Histograma.Add(points00);
                Histograma.Add(points10);
                Histograma.Add(points20);
                Histograma.Add(points30);
                Histograma.Add(points40);
                Histograma.Add(points50);
                Histograma.Add(points60);
                Histograma.Add(points70);
                Histograma.Add(points80);
                Histograma.Add(points90);
                Histograma.Add(points100);

                foreach (var list in Histograma)
                {
                    foreach (var numbers in list)
                    {
                        Console.WriteLine(numbers);
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            
        }
    }
}
