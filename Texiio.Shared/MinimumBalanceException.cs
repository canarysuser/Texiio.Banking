using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texiio.Shared
{
    public class MinimumBalanceException : Exception
    {
        public MinimumBalanceException(string message) : base(message) { }
        public MinimumBalanceException() :base("Insufficient Funds") { }
        public MinimumBalanceException(string message, Exception innerException) : base(message, innerException) { }



    }

    

}
