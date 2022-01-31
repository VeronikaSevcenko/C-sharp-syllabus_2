using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_and_Food
{
    public class Cat : Felime
    {
        private string _breed;

        public Cat (string type, string name, double weight, int foodEaten, string breed,string location) : base(type, name, weight, foodEaten, location)
        {
            _breed = breed;
        }

        public override string MakeNoise()
        {
            return" Meowwww, where is my food,human! ";
        }

        public override int Eat(Food food)
        {
            if (food.ToString() == "Vegetable" || food.ToString() == "Meat")
                GetFood += food.GetQuantity;

            return GetFood;
        }

        public override string ToString()
        {
            return _type + ", " + _name + ", " + _weight + ", " + _foodEaten + ", " + _breed + ", " + _location;
        }
    }
}
