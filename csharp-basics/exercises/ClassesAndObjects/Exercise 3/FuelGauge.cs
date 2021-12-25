using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3
{
    class FuelGauge
    {
       public int MaxLitr = 70;

        private int _Litr;

        public FuelGauge()
        {
            _Litr = 0;
        }

        public FuelGauge(int Litr)
        {
            if (Litr <= MaxLitr)
            {
                this._Litr = Litr;
            }
            else
            {
                Litr = MaxLitr;
            }
        }

        public int GetLitr()
        {
            return _Litr;
        }

        public void AddLitr()
        {
            if (_Litr < MaxLitr)
            {
                _Litr++;
            }
            else
            {
                Console.WriteLine("It's Full");
            }
        }

        public void Burn()
        {
            if (_Litr > 0)
            {
                _Litr--;
            }
            else
            {
                Console.WriteLine("No Fuel");
            }
        }
    }
}
