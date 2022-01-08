using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_and_Food
{
    class Meat : Food
    {
        public Meat(int quant) : base(quant)
        {

        }

        public  string DisplayFood()
        {
            return $"Meat {_quant}";
        }
    }
}
