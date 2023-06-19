using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public class Exceptions : Exception
    {

        public override string Message
        {
            get
            {
                return "Kumbara Doldu";
            }
        }

    }
}