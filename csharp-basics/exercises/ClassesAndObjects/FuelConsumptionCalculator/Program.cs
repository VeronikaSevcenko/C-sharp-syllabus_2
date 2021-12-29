using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            double startKilometers;
            double liters;
            int endKilometers;

            Car car1 = new Car(0);
            Car car2 = new Car(0);
            Console.Write("Enter first reading: ");
            startKilometers = Convert.ToDouble(Console.ReadLine());
            car1 = new Car(startKilometers);

            Console.Write("Enter first reading: ");
            startKilometers = Convert.ToDouble(Console.ReadLine());
            car2 = new Car(startKilometers);

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter the second reading: ");
                endKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters reading: ");
                liters = Convert.ToDouble(Console.ReadLine());

                car1.FillUp(endKilometers, liters);
                startKilometers = (double)endKilometers;
                car1._startKilometers = startKilometers;

                Console.WriteLine();

                Console.Write("Enter the second reading car");
                endKilometers = Convert.ToInt32(Console.ReadLine());  
                Console.Write("Enter liters reading: ");
                liters = Convert.ToDouble(Console.ReadLine());

                car2.FillUp(endKilometers, liters);
                startKilometers = (double)endKilometers;
                car2._startKilometers = startKilometers;
            }

            Console.WriteLine("Kilometers per liter are " + car1.CalculateConsumption() + " gasHog:" + car1.GasHog());
            Console.WriteLine("Car1 Kilometers per liter are " + car2.CalculateConsumption()+ " economyCar:" + car2.EconomyCar());
            Console.ReadKey();
        }
    }
}
