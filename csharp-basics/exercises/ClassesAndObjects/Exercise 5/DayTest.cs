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
            myDate.DisplayDate();

            Console.WriteLine("Enter the day");
            int myDay = Convert.ToInt32(Console.ReadLine());
            myDate.GetDayDate(myDay);

            Console.WriteLine("Enter the month");
            int myMonth = Convert.ToInt32(Console.ReadLine());
            myDate.GetMothDate(myMonth);

            Console.WriteLine("Enter the year");
            int myYear = Convert.ToInt32(Console.ReadLine());
            myDate.GetYearDate(myYear);
            myDate.DisplayDate();
        }
    }
}
