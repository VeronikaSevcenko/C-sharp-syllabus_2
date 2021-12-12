using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Dog
    {
        private string name;

        public enum Sex
        {
            male,
            female, 
        }

        private Sex sex;

        public Dog(string name, string sex)
        {

        }

        public Dog(string name,Sex sex)
        {
            this.name = name;
            this.sex = sex;
        }
    }
    class DogTest
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Max",Dog.Sex.male);
            Dog dog2 = new Dog("Rocky", Dog.Sex.male);
            Dog dog3 = new Dog("Sparky", Dog.Sex.male);
            Dog dog4 = new Dog("Buster", Dog.Sex.male);
            Dog dog5 = new Dog("Sam", Dog.Sex.male);
            Dog dog6 = new Dog("Lady", Dog.Sex.female);
            Dog dog7 = new Dog("Molly", Dog.Sex.female);
            Dog dog8 = new Dog("Coco", Dog.Sex.female);

            Console.WriteLine($"Dogs { dog1}");
        }
    }
}
