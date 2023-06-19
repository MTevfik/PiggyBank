using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Exceptions
{
    public class FullMoneyBox : Exception
    {
        public FullMoneyBox() : base("Kumbara dolu!")
        {

        }
    }
}
