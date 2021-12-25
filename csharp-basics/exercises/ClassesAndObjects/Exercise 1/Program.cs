using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Product
    {
        private string name;
        private double priceAtStart;
        private double amountAtStart;

        public Product(string Name, double PriceAtStart, int AmountAtStart)
        {
            name = Name;
            priceAtStart = PriceAtStart;
            amountAtStart = AmountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine("Name: {0}\nPriceAtStart : {1} EUR\nAmountAtStart: {2} units\n", name, priceAtStart, amountAtStart);
        }

        public void ChangePrice(double newPrice)
        {
            priceAtStart = newPrice;
        }

        public void ChangeSmallCount(double newCount)
        {
            amountAtStart -= newCount;
        }

        public void ChangeBiggCount(double newCount)
        {
            amountAtStart += newCount;
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
                Console.WriteLine("Name: {0}\nnewPrice: {1} EUR\nnewCount:{2} units", product2.name,product2.priceAtStart,product2.amountAtStart);
            }
        }
    }
}
