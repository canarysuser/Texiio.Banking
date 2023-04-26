using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texiio.Shared;

namespace Texiio.Process
{
    public interface IAccount
    {
        void Deposit(double amount);
        void Withdraw(double amount);
        void FundTransfer(IAccount account, double amount);
        string ToString();
        event TransactionEventHandler DepositEvent;
    }
}
