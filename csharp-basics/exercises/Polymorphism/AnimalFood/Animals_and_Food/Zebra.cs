﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_and_Food
{
    class  Zebra : Mammal
    {
        public Zebra(string type, string name, double weight, int foodEaten, string location) : base(type, name, weight, foodEaten, location)
        {

        }

        public override void MakeNoise()
        {
            Console.WriteLine(" Jui JUI JUI  ");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                _foodEaten += food._quant;

                Console.WriteLine(($"{_type} {_name} {_weight} {_foodEaten}"));
            }
            else
            {
                Console.WriteLine($"{_type} Are not eating that type of food!");
            }

        }

        public override void Display()
        {
            Console.WriteLine($"{_type} {_name} {_weight} {_foodEaten}");
        }

    }
}
