using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_and_Food
{
    public class Tiger : Felime
    {
        public Tiger(string type, string name, double weight, int foodEaten, string location) : base(type, name, weight, foodEaten, location)
        {

        }

        public override string MakeNoise()
        {
            return "ROAAAAAAAAAAAAAAAAAAAR";
        }

        public override int Eat(Food food)
        {
            if (food.ToString() == "Meat")
                GetFood += food.GetQuantity;
            else
                throw new ArgumentException(GetAnimalType + " " + "this animal are not eating this food food!");

            return GetFood;
        }

        public override string ToString()
        {
            return _type + ", " + _name + ", " + _weight + ", " + _foodEaten + ", " + _location;
        }
    }
}
