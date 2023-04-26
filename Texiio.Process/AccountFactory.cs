using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texiio.Shared;

namespace Texiio.Process
{
    public class AccountFactory
    {
        //DESIGN PATTERN: Factory Method Pattern. 
        //Purpose: Create a new object based on requirements/inputs
        public static IAccount Create(int id, string name, AccountType type, double amount)
        {
            IAccount acc = null!;
            if(type==AccountType.Savings && amount > 9999)
            {
                acc = new Savings(id, name, type, amount);
            } else if(type==AccountType.Current &&  amount > 24999)
            {
                acc = new Current(id,name, type, amount);
            } 
            //TODO else throw exceptions
            return acc;
        }
    }
}
