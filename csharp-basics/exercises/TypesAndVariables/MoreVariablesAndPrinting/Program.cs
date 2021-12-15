using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            string Eyes;
            string Teeth; 
            string Hair;
            int Age;
            double Height; 
            double Weight;

            Name = "Zed A. Shaw";
            Age = 35;
            Height = 74 * 2.54;  
            Weight = 180 * 0.45; 
            Eyes = "Blue";
            Teeth = "White";
            Hair = "Brown";

            Console.WriteLine("Let's talk about " + Name + ".");
            Console.WriteLine("He's " + Height + " cm tall.");
            Console.WriteLine("He's " + Weight + " kg heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + Eyes + " eyes and " + Hair + " hair.");
            Console.WriteLine("His teeth are usually " + Teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + Age + ", " + Height + ", and " + Weight
                               + " I get " + (Age + Height + Weight) + ".");

            Console.ReadKey();
        }
    }
}