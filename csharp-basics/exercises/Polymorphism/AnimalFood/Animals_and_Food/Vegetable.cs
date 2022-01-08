using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_and_Food
{
    class Vegetable : Food
    {
        public Vegetable(int quant) : base(quant)
        {

        }

        public string DisplayFood()
        {
            return $"Vegetable {_quant}";
        }
    }
}
