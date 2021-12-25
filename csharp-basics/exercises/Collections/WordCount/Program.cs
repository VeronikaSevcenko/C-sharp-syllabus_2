using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLines = File.ReadAllLines(@"C:\Users\37123\Desktop\C-sharp-syllabus_2\csharp-basics\exercises\Collections\WordCount\lear.txt").Length;
            
            StreamReader file = new StreamReader(@"C:\Users\37123\Desktop\C-sharp-syllabus_2\csharp-basics\exercises\Collections\WordCount\lear.txt");

            int countWords = 0;
            int countChars = 0;
            string line;

            while ((line = file.ReadLine()) != null)
            {
                String[] words = line.Split(' ');

                countWords += words.Length;

                string[] text = File.ReadAllLines(@"C:\Users\37123\Desktop\C-sharp-syllabus_2\csharp-basics\exercises\Collections\WordCount\lear.txt");

                for (int i = 0; i < text.Count(); i++)
                {
                    countChars += text[i].Length;
                }
            }
            file.Close();
        
            Console.WriteLine("Lines = {0} ", +countLines);
            Console.WriteLine("Words = {0}", +countWords);
            Console.WriteLine("Chars = {0}", +countChars);
        }
    }
}
