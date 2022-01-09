using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Product
    {
        private string name;
        private double _priceAtStart;
        private double amountAtStart;

        public Product(string Name, double PriceAtStart, int AmountAtStart)
        {
            name = Name;
            _priceAtStart = PriceAtStart;
            amountAtStart = AmountAtStart;
        }

        public string PrintProduct()
        {
            return  name + ", " + _priceAtStart + ", " + amountAtStart;
        }

        public void ChangePrice(double newPrice)
        {
            _priceAtStart = newPrice;
        }

        public double ChangeSmallCount(double newCount)
        {
            return amountAtStart -= newCount;
        }

        public double ChangeBiggCount(double newCount)
        {
            return amountAtStart += newCount;
        }
       
        class MainClass
        {
            public static void Main(string[] args)
            {
                Product product1 = new Product("Logitech mouse", 70.00, 14);
                product1.PrintProduct();

                Product product2 = new Product("iPhone 5s", 999.99, 3);
                product2.PrintProduct();
                
                Product product3 = new Product("Epson EB-U05", 440.46, 1);
                product3.PrintProduct();
                
                product2.ChangePrice(890.00);
                product2.ChangeSmallCount(2);
                product2.ChangeBiggCount(1);
                Console.WriteLine("Name: {0}\nnewPrice: {1} EUR\nnewCount:{2} units", product2.name,product2._priceAtStart,product2.amountAtStart);
            }
        }
    }
}
