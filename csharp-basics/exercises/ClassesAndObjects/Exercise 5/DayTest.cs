using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_5
{
    class DayTest
    {
        static void Main(string[] args)
        {
            Date myDate = new Date(2, 11, 1995);

            Console.WriteLine("Enter the day");
            int myDay = int.Parse(Console.ReadLine());
            myDate.DayDate(myDay);

            Console.WriteLine("Enter the month");
            int myMonth = int.Parse(Console.ReadLine());
            myDate.DayDate(myMonth);

            Console.WriteLine("Enter the year");
            int myYear = int.Parse(Console.ReadLine());
            myDate.DayDate(myYear);
            myDate.DisplayDate();
        }
    }
}
