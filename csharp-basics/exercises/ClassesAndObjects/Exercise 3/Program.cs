using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        public class CarSimulator
        {
            public static void Main(string[] args)
            {
                FuelGauge fuel = new FuelGauge();
                Odometer odometer = new Odometer(0, fuel);

                for (int i = 0; i < fuel.MaxLitr; i++)
                {
                    fuel.AddLitr();
                }

                while (fuel.GetLitr() > 0)
                {
                    odometer.AddMileage();
                }
                Console.WriteLine("Mileage:" + odometer.GetMileage());
                Console.WriteLine("Fuel level:" + fuel.GetLitr() + " litr");
            }
        }
    }
}
