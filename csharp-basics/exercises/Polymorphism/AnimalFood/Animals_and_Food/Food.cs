using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_and_Food
{
    public abstract class Food
    {
        public int _quant;

        public Food(int quant)
        {
            _quant = quant;
        }

        public int GetQuantity
        {
            get { return _quant; }
            set { _quant = value; }
        }
    }
}
