using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAndEmployee
{
    class Student : Person
    {
        public double _GPA;

        public Student(string _firstName, string _lastName, string _adress, int _id, double GPA) : base(_firstName, _lastName, _adress, _id)
        {
            _GPA = GPA;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Student GPA: " + _GPA);
        }
    }
}
