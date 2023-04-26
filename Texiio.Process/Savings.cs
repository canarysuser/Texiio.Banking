using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texiio.DataAccess;
using Texiio.Shared;

namespace Texiio.Process
{
    internal class Savings : Account
    {
        public Savings(AccountInfo info) : base(info) { }
        public Savings(int id, string name, AccountType type, double amount)
            : base(id, name, type, amount) { }

        public override void Withdraw(double amount)
        {
            if ((_info.Balance - amount) > 4999) 
                _info.Balance -= amount;
            else
                throw new MinimumBalanceException("Insufficient funds in the account.");
        }
    }
}
