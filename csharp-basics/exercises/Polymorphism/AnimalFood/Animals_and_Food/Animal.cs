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

        public virtual int Eat(Food food)
        {
            return GetFood;
        }

        public string GetAnimalType
        {
            get { return _type; }
            set { _type = value; }
        }

        public int GetFood
        {
            get { return _foodEaten; }
            set { _foodEaten = value; }
        }

        public abstract string MakeNoise();
    }
}
