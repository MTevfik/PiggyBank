using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public class MoneyBox
    {
        public MoneyBox(int value)
        {
            MoneyBoxValue = value;
        }
        public double MoneyBoxValue { get; set; }
        public double Shake(double extraVolume)
        {
            Random rnd = new Random();
            return extraVolume = extraVolume * rnd.Next(25, 75) * 0.01;
        }
        public double Amount { get; set; }
        public double RateOfFull => Amount / MoneyBoxValue;
        public void Add(double amount)
        {
            Amount += amount;
        }
    }
}
