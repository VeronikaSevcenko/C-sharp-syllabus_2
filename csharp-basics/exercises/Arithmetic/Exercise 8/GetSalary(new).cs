using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_8
{
    public class GetSalary_new_
    {
        public static string GetSalary(double basePay, int hoursWorked)
        {
            double minWage = 8;
            int maxHours = 60;
            double totalSalary = 0;
           
            if ((basePay < minWage) || (hoursWorked > maxHours))
            {
                Console.WriteLine("Error");
            }
            else if (hoursWorked > 40)
            {
                totalSalary = basePay * 40 + 1.5 * basePay * (hoursWorked - 40);
                return "The salary is " + totalSalary + "$";
            }
            else
            {
                totalSalary = basePay * hoursWorked;
                return "Employee have earned " + totalSalary + "$";
            }
            return "Error";
        }
    }
}
