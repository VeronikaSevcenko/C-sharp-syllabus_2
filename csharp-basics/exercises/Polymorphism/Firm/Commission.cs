using DotLiquid.Tags;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    public class Commission : Hourly
    {
        private double _totalSales;

        public double _commission_rate;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commission_rate, double hoursWorked) : 
            base(eName, eAddress, ePhone, socSecNumber, rate, hoursWorked)
        {
            _commission_rate = commission_rate;
        }

        public void AddSales(double totalSales)
        {
            _totalSales += totalSales;
        }

        public override double Pay()
        {
            double amount = base.Pay();
            _totalSales = 0;
            return amount;
        }

        public override string ToString()
        {
            string p = base.ToString() + "\n Total sales: " + _totalSales;

            return p;
        }
    }
}
