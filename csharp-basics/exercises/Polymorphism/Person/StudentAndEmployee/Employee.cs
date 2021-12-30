using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAndEmployee
{
    class Employee : Person
    {
        public string _jobTitle;

        public Employee(string _firstName, string _lastName, string _adress, int _id, string jobTitle) : base(_firstName, _lastName, _adress, _id)
        {
            _jobTitle = jobTitle;
        }

        public string JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

         public override void Display()
        {
            base.Display();
            Console.WriteLine("Employee job title: " + _jobTitle);
        }
    }
}
