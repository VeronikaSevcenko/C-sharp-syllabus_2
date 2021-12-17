using System;
using System.Collections.Generic;
using System.Text;


namespace Exercsie_8
{
    class Test
    {
        static void Main(string[] args)
        {
            double balance = 0.00;
            double interestRate = 0.00;
            int months = 0;
            double depositAmount;
            double withdrawAmount;
            double totalDeposits = 0.00;
            double totalWithdrawn = 0.00;

            SavingsAccount Account = new SavingsAccount(balance, interestRate);

            Console.WriteLine("How much money is in the account?:");
            balance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the annual interest rate:");
            interestRate = double.Parse(Console.ReadLine());
            Account.GetInterestRate();

            Console.WriteLine("How long has the account been opened?(months):");
            months = int.Parse(Console.ReadLine());
            for (int month = 1; month <= months; month++)
            {
                balance = Account.GetBalance();
            }

            Console.WriteLine("Enter amount deposited for month:" + months);
            depositAmount = double.Parse(Console.ReadLine());
            Account.AddDeposit();
            totalDeposits = (totalDeposits + depositAmount);

            Console.WriteLine("Enter amount withdrawn for 1:" + months);
            withdrawAmount = double.Parse(Console.ReadLine());
            Account.subtractWithdraw();
            totalWithdrawn = (totalWithdrawn + withdrawAmount);
            Account.CalculateInterest();
            Account.AddInterest();

            Account.AddTotalDeposit();
            Account.GetTotalDeposit();
            Console.WriteLine($"Total deposited:${totalDeposits}");

            Account.AddTotalWithdraw();
            Account.GetTotalDeposit();
            Console.WriteLine($"Total withdrawn:${totalWithdrawn}");

            Console.WriteLine($"Ending balance:${Account.GetBalance()}");

            Account.AddInterest();
            Account.GetInterest();
            Console.WriteLine($"Interest earned:${interestRate}");
        }
    }
}
