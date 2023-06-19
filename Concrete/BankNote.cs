using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public class BankNote : Money, IFoldable
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; } = 0.25;
        public override double Value()
        {
            return Width * Length * Height;
        }
        public double ExtraVolume(double value)
        {
            double space;
            Random rnd = new Random();
            return space = value * rnd.Next(25, 75) * 0.01;
        }
        public double Fold(double banknoteValue)
        {
            return (Width / 4) * Length * (Height * 4);
        }
        public override string ToString()
        {
            return $"{Key}";
        }
    }
}
