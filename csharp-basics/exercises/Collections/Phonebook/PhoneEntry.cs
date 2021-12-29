using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneEntry
    {
        public string _name;
        public string _number;

        public PhoneEntry(string name, string number)
        {
            _name = name;
            _number = number;

        }
    }
}