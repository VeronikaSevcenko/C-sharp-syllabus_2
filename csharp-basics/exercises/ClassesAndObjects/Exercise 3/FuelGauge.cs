using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3
{
    class FuelGauge
    {
       public int MaxLitr = 70;

        private int _litr;

        public FuelGauge()
        {
            _litr = 0;
        }

        public FuelGauge(int Litr)
        {
            if (Litr <= MaxLitr)
            {
                this._litr = Litr;
            }
            else
            {
                Litr = MaxLitr;
            }
        }

        public int GetLitr()
        {
            return _litr;
        }

        public void AddLitr()
        {
            if (_litr < MaxLitr)
            {
                _litr++;
            }
            else
            {
                Console.WriteLine("It's Full");
            }
        }

        public void Burn()
        {
            if (_litr > 0)
            {
                _litr--;
            }
            else
            {
                Console.WriteLine("No Fuel");
            }
        }
    }
}
