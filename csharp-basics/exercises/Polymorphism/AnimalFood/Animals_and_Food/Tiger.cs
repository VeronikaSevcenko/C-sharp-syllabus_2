using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_and_Food
{
    class Tiger : Felime
    {

        public Tiger(string type, string name, double weight, int foodEaten, string location) : base(type, name, weight, foodEaten, location)
        {

        }
        public override void MakeNoise()
        {
            Console.WriteLine(" ROAAAAAAAAAAAAAAAAAAAR ");
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                _foodEaten += food._quant;

                Console.WriteLine(($"{_type} {_name} {_weight} {_foodEaten} {_location}"));
            }
            else
            {
                Console.WriteLine($"{_type} Are not eating that type of food!");
            }

        }

        public override void Display()
        {
            Console.WriteLine($"{_type} {_name} {_weight} {_foodEaten} {_location}");
        }
    }
}
