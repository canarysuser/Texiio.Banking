using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texiio.Shared;

namespace Texiio.DataAccess
{
    //Maintains the Account Details like ID, Name, Type and balance 
    public class AccountInfo
    {
        #region Fields 
        private int _id; 
        private string _name=string.Empty;
        private AccountType _type;
        private double _balance;
        #endregion

        #region Properties 
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public AccountType Type { get { return _type; } set { _type = value; } }
        public double Balance { get { return _balance; } set { _balance = value; } }
        #endregion

        #region Constructors 
        private AccountInfo() { }
        public AccountInfo(int id, string name, AccountType type, double balance)
            => (_id, _name, _type, _balance) = (id, name, type, balance);
        //tuples concept where we create a type without defining the class. 
        //temporary data placeholders can be created using tuples. 

        #endregion 
    }
}
