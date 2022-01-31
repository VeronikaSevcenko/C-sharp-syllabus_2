using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_and_Food
{
    class Mouse : Mammal
    {
        public Mouse(string type, string name, double weight, int foodEaten, string location) : base(type, name, weight, foodEaten,location)
        {
           
        }

        public override string MakeNoise()
        {
            return" Piuuu pi pi pi piuuuu ";
        }

        public override int Eat(Food food)
        {
            if (food.ToString() == "Vegetable" || food.ToString() == "Meat") ;
                GetFood += food.GetQuantity;

            return GetFood;
        }

        public override string ToString()
        {
            return _type + ", " + _name + ", " + _weight + ", " + _foodEaten + ", " + _location;
        }
    }
}
