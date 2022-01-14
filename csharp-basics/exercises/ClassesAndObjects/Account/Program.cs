using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account bartosAccount = new Account("Barto's account", 100.00);
            Console.WriteLine(bartosAccount);

            bartosAccount.Deposit(20);
            Console.WriteLine("Barto's account balance is now: " + bartosAccount.Balance());

            Account mattAccount = new Account("Matt's account", 1000);
            Account myAccount = new Account("My account", 0);

            Console.WriteLine(mattAccount);
            Console.WriteLine(myAccount);

            mattAccount.Withdrawal(100.0);
            Console.WriteLine("Matt's account balance is now: " + mattAccount.Balance());
            myAccount.Deposit(100.0);
            Console.WriteLine("My account balance is now: " + myAccount.Balance());

            Account Account_A = new Account("A", 100.00);
            Account Account_B = new Account("B", 0);
            Account Account_C = new Account("C", 0);

            Account.Transfer(Account_A, Account_B, 50.0);
            Account.Transfer(Account_B, Account_C, 25.0);

            Console.WriteLine(Account_A);
            Console.WriteLine(Account_B);
            Console.WriteLine(Account_C);

            Console.WriteLine(Account_A);
            Console.WriteLine(Account_B);
            Console.WriteLine(Account_C);
        }
    }
}
