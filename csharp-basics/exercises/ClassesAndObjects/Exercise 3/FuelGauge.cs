using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3
{
    class FuelGauge
    {
       public int MaxLitr = 70;

        private int Litr;

        public FuelGauge()
        {
            Litr = 0;
        }

        public FuelGauge(int Litr)
        {
            if (Litr <= MaxLitr)
            {
                this.Litr = Litr;
            }
            else
            {
                Litr = MaxLitr;
            }
        }
        public int GetLitr()
        {
            return Litr;
        }

        public void AddLitr()
        {
            if (Litr < MaxLitr)
            {
                Litr++;
            }
            else
            {
                Console.WriteLine("It's Full");
            }
        }
        public void Burn()
        {
            if (Litr > 0)
            {
                Litr--;
            }
            else
            {
                Console.WriteLine("No Fuel");
            }
        }
    }
}
