using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_and_Food
{
    public class Vegetable : Food
    {
        public Vegetable(int quant) : base(quant)
        {

        }

        public override string ToString()
        {
            return "Vegetable";
        }
    }
}
