using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Exceptions
{
    public class EmptyMoneyBox : Exception
    {
        public EmptyMoneyBox() : base("Kumbara boş!")
        {

        }
    }
}
