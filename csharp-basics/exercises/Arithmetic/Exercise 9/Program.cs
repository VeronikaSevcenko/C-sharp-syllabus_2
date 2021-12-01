using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double BMI;
            int weight;
            double height;

            Console.WriteLine("Please,write your weight");
            weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Please, write your height");
            height = double.Parse(Console.ReadLine());

            BMI = weight / (height * height);

            if (BMI < 18.5)
            {
                Console.WriteLine("Your BMI category is : Starvation," + "but you are so beautiful!");
            }
            else if (BMI > 25)
            {
                Console.WriteLine("Your BMI category is : Overweight," + "but you are so beautiful");
            }
        }
    }
}
