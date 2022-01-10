using System;
using System.Collections.Generic;

namespace Animals_and_Food
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Animal animalTiger = new Tiger("Rex", "White", 168.2, 0, "Asia");
            Animal animalCat = new Cat("Garfild", "Gray", 1.8, 4,"Persian", "Flat");
            Animal animalZebra = new Zebra("Alex", "White and Black", 110.8, 4, "Madagaskar");
            Animal animalMouse = new Mouse("Jerry", "Brown", 0.121, 2, "Meadows");

            animals.Add(animalMouse);
            animals.Add(animalTiger);
            animals.Add(animalCat);
            animals.Add(animalZebra);
            
            Food foodmeat = new Meat(8);
            Food foodvegetable = new Vegetable(3);

            foreach (var animal in animals)
            {
                animal.ToString();
                animal.MakeNoise();
                Console.WriteLine(foodvegetable);
                animal.Eat(foodvegetable);
                
            }
            foreach (var animal in animals)
            {
                animal.ToString();
                animal.MakeNoise();
                Console.WriteLine(foodmeat);
                animal.Eat(foodmeat);

            }
        }
    }
}
