using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    public class CheckNumbers
    {
        public static bool TwoIntegers(int a, int b)
        {
            return a == 15 || b == 15 || a + b == 15 || Math.Abs(a - b) == 15;
        }
    }
}
