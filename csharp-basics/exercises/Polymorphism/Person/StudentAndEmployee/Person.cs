using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAndEmployee
{
    public class Person
    {
        public string _firstName;
        public string _lastName;
        public string _adress;
        public int _id;

        public Person() 
        {
        }
        public Person(string firstName, string lastName, string adress, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _adress = adress;
            _id = id;
        }

        public string FirstName
        {
            get { return _firstName;}
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual void Display()
        {
            Console.WriteLine(" First name: {0}  ", FirstName);
            Console.WriteLine(" Last name: {0} " , LastName);
            Console.WriteLine(" Adress; {0} " , Adress);
            Console.WriteLine(" ID: {0}" , ID);
        }
    }
}
