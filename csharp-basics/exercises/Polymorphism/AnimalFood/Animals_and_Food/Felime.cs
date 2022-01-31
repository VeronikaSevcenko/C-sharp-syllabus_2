using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_and_Food
{
    public abstract class Felime : Mammal
    {
        public Felime(string type, string name, double weight, int foodEaten, string location) : base (type, name, weight, foodEaten, location)
        {

        }

    }
}
