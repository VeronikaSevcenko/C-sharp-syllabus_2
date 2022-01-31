using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_and_Food
{
    public abstract class Mammal : Animal
    {
        protected string _location;

        public Mammal(string type, string name, double weight, int foodEaten, string location) : base (type, name, weight, foodEaten)
        {
            _location = location;
        }

        public string GetLocation
        {
            get { return _location; }
            set { _location = value; }
        }
    }
}
