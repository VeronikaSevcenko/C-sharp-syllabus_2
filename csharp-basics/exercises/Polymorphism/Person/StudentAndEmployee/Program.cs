using System;

namespace StudentAndEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student("Mike", "Michegun", "Horter stree 45", 696779878, 7.5);
            Person employee = new Employee("Marbol", "Koriston", "Mambo stree 8", 57456464, "Teacher");

            student.Display();

            Console.WriteLine("------------------------------");

            employee.Display();
        }
    }
}
