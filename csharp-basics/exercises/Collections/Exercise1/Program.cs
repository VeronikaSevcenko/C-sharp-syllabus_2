using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> array = new List<string>();
            array.Add("Audi");
            array.Add("BMW");
            array.Add("Honda");
            array.Add("Mercedes-Benz");
            array.Add("VolksWagen");
            array.Add("Mercedes-Benz");
            array.Add("Tesla");

            foreach (var result in array)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine();

            HashSet<string> array2 = new HashSet<string>()
            {
                "Audi",
                "BMW",
                "Honda",
                "Mercedes-Benz",
                "VolksWagen",
                "Mercedes-Benz",
                "Tesla"
            };
            foreach (var result in array2)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine();

            Dictionary<string,string> array3 = new Dictionary<string, string>()
            {
                { "Audi", "Germany"},
                { "BMW", "Germany"},
                { "Honda", "Japan" },
                { "Mercedes-Benz", "Germany"},
                { "VolksWagen", "Germany" },
                { "Tesla", "USA" },
            };

            foreach (var result in array3) 
            Console.WriteLine("{0} -> {1}",result.Key, result.Value);
        }
    }
}
