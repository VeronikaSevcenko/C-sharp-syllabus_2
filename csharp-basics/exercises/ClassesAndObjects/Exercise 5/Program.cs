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
        public int Month
        {
            get { return _month; }
            set { _month = value; }
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
}
