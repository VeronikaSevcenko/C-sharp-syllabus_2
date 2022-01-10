using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_and_Food
{
    public class Meat : Food
    {
        public Meat(int quant) : base(quant)
        {

        }

        public override string ToString()
        {
            return "Meat";
        }
    }
}
