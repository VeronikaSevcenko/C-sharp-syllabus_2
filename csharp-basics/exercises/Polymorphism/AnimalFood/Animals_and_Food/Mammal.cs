using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_and_Food
{
    public  class Mammal : Animal
    {
        protected string _location;

        public Mammal(string type, string name, double weight, int foodEaten, string location) : base (type, name, weight, foodEaten)
        {
            _location = location;
        }

        public override void Eat(Food food)
        {
            
        }

        public override void Display()
        {
            Console.WriteLine($"{_type} {_name} {_weight} {_foodEaten} {_location}");
        }
    }
}
