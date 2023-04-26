using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texiio.DataAccess;
using Texiio.Shared;

namespace Texiio.Process
{
    public abstract class Account : IAccount
    {
        protected AccountInfo _info;
        public event TransactionEventHandler DepositEvent;
        public event TransactionEventHandler WithdrawEvent;

        private Account() {  }
        public Account(AccountInfo info) { _info = info; }
        public Account(int id, string name, AccountType type, double amount)
            =>_info = new AccountInfo(id, name, type, amount);

        protected void OnDepositEvent(double amount)
        {
            TransactionEventArgs e = new TransactionEventArgs
            {
                AccountId = _info.Id,
                Amount = amount,
                TransactionType = TransactionType.Deposit,
                TransactionDate = DateTime.Now,
            };
            DepositEvent?.Invoke(this, e);
        }

        public void Deposit(double amount)
        {
            _info.Balance += amount;
            OnDepositEvent(amount);
        }
        public abstract void Withdraw(double amount);
        //public virtual void Withdraw(double amount) { }

        //public void Withdraw(double amount) => _info.Balance -= amount; 
        //public void Withdraw(double amount)
        //{
        //    if(_info.Type==AccountType.Savings && (_info.Balance-amount)>4999)
        //        _info.Balance -= amount;
        //    else if (_info.Type == AccountType.Current&& (_info.Balance - amount) > 9999)
        //        _info.Balance -= amount;
        //    //else do nothing.
        //}

        //Design Pattern: Template Method Pattern
        public void FundTransfer(IAccount target, double amount)
        {
            this.Withdraw(amount);
            target.Deposit(amount);
        }
        public override string ToString()
        {
            return $"Id:{_info.Id}, Name:{_info.Name}, Type:{_info.Type}, Balance:{_info.Balance}";
        }

    }
}
