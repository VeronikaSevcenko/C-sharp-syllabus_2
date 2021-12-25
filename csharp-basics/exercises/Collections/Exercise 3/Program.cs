using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();

            Console.WriteLine("Enter blank line to stop!");

            Console.WriteLine("Enter the name");
            string inputName = Console.ReadLine();

            while (!String.IsNullOrEmpty(inputName))
            {
                if (!nameList.Contains(inputName))
                {
                    nameList.Add(inputName);
                }else
                {
                    Console.WriteLine("Enter next  Name:");
                    inputName = Console.ReadLine();
                }
            }
            foreach (string Name in nameList)
            {
                Console.WriteLine(" " + Name);
            }
        }
    }
}

