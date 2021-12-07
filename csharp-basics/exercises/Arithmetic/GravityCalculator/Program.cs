
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravity = -9.81;
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double finalPosition = 0.0;
            Console.WriteLine("The object's position after " + fallingTime + " seconds is "
                + (0.5 * gravity * (Math.Pow(fallingTime, 2))) + (initialPosition * fallingTime) + finalPosition + " m.");
            Console.ReadKey();
        }
    }
}
