using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        private string _name;
        private double _balance;

        public BankAccount(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            if (_balance >= 0)
            {
                return $" {_name}, ${String.Format("{0:0.00}", _balance)}";
            }
            else  
            {
                return $" {_name}, -${String.Format("{0:0.00}", (_balance * -1))}";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount("Benson", -17.5);

            Console.WriteLine(bank.ShowUserNameAndBalance());

            Console.ReadKey();
        }
    }
}
