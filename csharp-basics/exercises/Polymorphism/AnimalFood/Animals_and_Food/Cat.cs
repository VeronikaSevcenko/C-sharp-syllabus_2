using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_and_Food
{
    class Cat : Felime
    {
        private string _breed;

        public Cat (string type, string name, double weight, int foodEaten, string breed,string location) : base(type, name, weight, foodEaten, location)
        {
            _breed = breed;
        }

        public override void MakeNoise()
        {
            Console.WriteLine(" Meowwww, where is my food,human! ");
        }

        public override void Eat(Food food)
        {

            _foodEaten += food._quant;

            Console.WriteLine(($"{_type} {_name} {_breed} {_weight} {_foodEaten}"));
        }


        public override void Display()
        {
            Console.WriteLine($"{_type} {_name} {_breed} {_weight} {_foodEaten}");
        }
    }
}
