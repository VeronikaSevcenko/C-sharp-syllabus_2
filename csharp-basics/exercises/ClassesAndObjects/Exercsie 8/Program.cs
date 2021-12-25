using System;

namespace Exercsie_8
{
    class SavingsAccount
    {
        private double _balance;
        private double withdraw;
        private double deposit;
        private double interestRate;
        private double interest;
        private double totalDeposit;
        private double totalWithdrawn;

        public SavingsAccount(double startBalance, double inteRate)
        {
            _balance = startBalance;
            interestRate = inteRate;
            interest = 0.00;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void GetDeposit(double depositAmount)
        {
            deposit = depositAmount;
        }

        public void AddDeposit()
        {
            _balance = (_balance + deposit);
        }

        public void SetWithdraw(double withdrawAmount)
        {
            withdraw = withdrawAmount;
        }

        public void subtractWithdraw()
        {
            _balance = (_balance - withdraw);
        }

        public double GetInterestRate()
        {
            return interestRate;
        }

        public void CalculateInterest()
        {
            interest = (interestRate / 12);
            interest = (_balance * interest);
        }

        public void AddInterest()
        {
            _balance = (_balance + interest);
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
