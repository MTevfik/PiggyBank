using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public abstract class Money
    {
        public string Key { get; set; }
        public double Val { get; set; }
        public abstract double Value();
        public double TotalValue()
        {
            Random rnd = new Random();
            double extraRnd = rnd.Next(25, 76);
            double extraValue = (extraRnd * Value()) / 100;
            return extraValue;
        }
    }
}
