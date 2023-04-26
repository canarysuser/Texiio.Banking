using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texiio.DataAccess;
using Texiio.Shared;

namespace Texiio.Process
{
    internal class Current : Account
    {
        public Current(AccountInfo info) : base(info) { }
        public Current(int id, string name, AccountType type, double amount)
            : base(id, name, type, amount) { }

        public override void Withdraw(double amount)
        {
            if ((_info.Balance - amount) > 9999)
                _info.Balance -= amount;
            //TODO else throw exceptions
        }
    }
}
