using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public class Coin : Money
    {
        public const double Pi = 3.14;
        public double Cap { get; set; }
        public double Height { get; set; }
        public override double Value()
        {
            return Height * Math.Pow(Cap,2) * Pi * (0.25);
        }
        public double ExtraVolume(double value)
        {
            double space;
            Random rnd = new Random();
            return space = value * rnd.Next(25, 75) * 0.01;
        }
        public override string ToString()
        {
            return $"{Key}";
        }
    }
}
