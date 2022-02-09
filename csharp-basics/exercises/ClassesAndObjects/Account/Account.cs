namespace Account
{
    public class Account
    {
        private string _name;
        private double _money;

        public Account(string name, double money)
        {
            _name = name;
            _money = money;
        }

        public double Withdrawal(double amount)
        {
           return  _money -= amount;
        }

        public double Deposit(double amount)
        {
            return _money += amount;
        }

        public double Balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public static double Transfer(Account from, Account to, double howMuch)
        {
            from.Withdrawal(howMuch);
            return to.Deposit(howMuch);
        }
    }
}
