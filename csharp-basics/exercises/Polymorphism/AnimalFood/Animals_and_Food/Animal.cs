using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_and_Food
{
    public abstract  class Animal 
    {
        protected string _type;
        protected string _name;
        protected double _weight;
        protected int _foodEaten;
        
        
        public Animal(string type, string name, double weight, int foodEaten)
        {
            _type = type;
            _name = name;
            _weight = weight;
            _foodEaten = foodEaten;

        }

        public virtual  void Eat(Food food)
        {
            
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine(" Animal makes a noise ");
        }

        public virtual void Display()
        {
            Console.WriteLine($"{_type} {_name} {_weight} {_foodEaten}");
        }
    }
}
