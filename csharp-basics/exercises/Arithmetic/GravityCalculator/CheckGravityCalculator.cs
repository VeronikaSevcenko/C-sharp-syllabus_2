using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravityCalculator
{
    public class CheckGravityCalculator
    {
        public static double GetTestGravity(double initialVelocity, double initialPosition, double fallingTime)
        {
            var gravity = -9.81;
            return 0.5 * gravity * Math.Pow(fallingTime, 2) + initialVelocity * fallingTime + initialPosition;
        }
    }
}