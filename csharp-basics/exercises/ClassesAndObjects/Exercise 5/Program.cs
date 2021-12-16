using System;

namespace Exercise_5
{
    class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = month;
            _day = day;
        }
        public void MothDate(int month)
        {
            _month = month;
        }
        public int GetMothDate()
        {
            return _month;
        }
        public void DayDate(int day)
        {
            _day = day;
        }
        public int GetDayDate()
        {
            return _day;
        }
        public void YearDate(int year)
        {
            _year = year;
        }
        public int GetYearDate()
        {
            return _year;
        }
        public void DisplayDate()
        {
            Console.WriteLine($"{_year}/{_month}/{_day}");
        }
    }
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
