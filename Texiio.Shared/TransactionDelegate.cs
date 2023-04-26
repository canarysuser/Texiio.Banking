using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texiio.Shared
{
   public enum TransactionType {  None, Deposit, Withdraw, FundTransfer }
   public class TransactionEventArgs : EventArgs
    {
        public int AccountId { get; set; }
        public double Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"A {TransactionType} of Rs. {Amount} was done on ")
                .Append($"your account no: {AccountId} on {TransactionDate:dd-MMM-yyyy hh:mm:ss}"); 
            return sb.ToString();
        }
    }
    public delegate void TransactionEventHandler(object sender, TransactionEventArgs e);

}
