using System;

namespace Exercsie_8
{
    class SavingsAccount
    {
        private double balance;
        private double withdraw;
        private double deposit;
        private double interestRate;
        private double interest;
        private double totalDeposit;
        private double totalWithdrawn;

        public SavingsAccount(double startBalance, double inteRate)
        {
            balance = startBalance;
            interestRate = inteRate;
            interest = 0.00;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void GetDeposit(double depositAmount)
        {
            deposit = depositAmount;
        }

        public void AddDeposit()
        {
            balance = (balance + deposit);
        }

        public void SetWithdraw(double withdrawAmount)
        {
            withdraw = withdrawAmount;
        }

        public void subtractWithdraw()
        {
            balance = (balance - withdraw);
        }

        public double GetInterestRate()
        {
            return interestRate;
        }

        public void CalculateInterest()
        {
            interest = (interestRate / 12);
            interest = (balance * interest);
        }

        public void AddInterest()
        {
            balance = (balance + interest);
        }

        public double GetInterest()
        {
            return interest;
        }

        public void AddTotalDeposit()
        {
            totalDeposit = totalDeposit + deposit;
        }

        public double GetTotalDeposit()
        {
            return totalDeposit;
        }

        public void AddTotalWithdraw()
        {
            totalWithdrawn = totalWithdrawn + withdraw;
        }

        public double GetTotalWithdraw()
        {
            return totalWithdrawn;
        }
    }
}
