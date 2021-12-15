using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3
{
    class Odometer
    {
        public int MaxMileage = 999999;

        private int Mileage;

        public int MPG = 24;

        private int OriginalMileaeg;

        private FuelGauge fuelGauge;

        public Odometer(int Mileage, FuelGauge fuelGauge)
        {
            this.OriginalMileaeg = Mileage;
            this.Mileage = Mileage;
            this.fuelGauge = fuelGauge;
        }

        public int GetMileage()
        {
            return Mileage;
        }
        public void AddMileage()
        {
            if (Mileage < MaxMileage)
            {
                Mileage++;
            }
            else
            {
                Mileage = 0;
            }

            var driving = OriginalMileaeg - Mileage;
            {
                if(driving % MPG == 0)
                {
                    fuelGauge.Burn();
                }
            }
        }
    }   
}
