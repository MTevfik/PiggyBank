using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Exceptions
{
    public class CanNotBeUsed : Exception
    {
        public CanNotBeUsed() : base("Kumbara kırıldıktan sonra 2. kez kullanılamaz!")
        {

        }
    }
}
