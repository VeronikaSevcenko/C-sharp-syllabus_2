using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double minWage = 8.0;
            int maxHours = 60;
            double basePay = 0;
            int hoursWorked = 0;
            double totalSalary = 0;

            if ((basePay < minWage) || (hoursWorked > maxHours))
            {
              Console.WriteLine("Error");
            }
            else if (hoursWorked > 40)
            {
              totalSalary = basePay * 40 + 1.5 * basePay * (hoursWorked - 40);
            }
            else
            {
              totalSalary = basePay * hoursWorked;
            }
            Console.WriteLine("Your total salary is " + totalSalary);
            Console.ReadKey();
        }
    }
}
