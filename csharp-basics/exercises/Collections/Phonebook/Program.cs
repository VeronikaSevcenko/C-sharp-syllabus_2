using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> phoneOwnerNames = new SortedDictionary<string, int>
            {
                { "Jorry", 28955674 },
                { "Molly", 27955642 }
            };

            foreach (KeyValuePair<string, int> info in phoneOwnerNames)
            {
                Console.WriteLine("{0} - {1}", info.Key, info.Value);

            }
        }
    }
}
