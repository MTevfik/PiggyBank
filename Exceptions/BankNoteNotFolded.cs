using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Exceptions
{
    public class BanknoteNotFolded : Exception
    {
        public BanknoteNotFolded() : base("Parayı kumbaraya atmak için önce katlamalısınız!")
        {

        }
    }
}
