// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;
using Texiio.DataAccess;
using Texiio.Process;
using Texiio.Shared; 


Console.Clear();
//Account acc = new(101, "Sample", AccountType.Savings, 10000);
IAccount acc = AccountFactory.Create(101, "Sample", AccountType.Savings, 10000);
if(acc is null)
{
    Console.WriteLine("Account not created.");
    return;
}
acc.DepositEvent += (s, e) => Console.WriteLine(e);

Console.WriteLine(acc.ToString());
acc.Deposit(5000);
Console.WriteLine( acc);
try
{
    acc.Withdraw(12000);
    Console.WriteLine(acc);
} catch (Exception ex) { Console.WriteLine( ex.Message); }

//Account acc2 = new(102, "Example", AccountType.Current, 25000);
IAccount acc2 = AccountFactory.Create(102, "Example", AccountType.Current, 25000);
if (acc2 is null)
{
    Console.WriteLine("Account not created.");
    return;
}
acc2.DepositEvent += (s, e) => Console.WriteLine(e);

Console.WriteLine(acc2);
acc2.FundTransfer(acc, 5000);
Console.WriteLine(acc);
Console.WriteLine(acc2);


Console.WriteLine("\n\nAll tasks completed. Press a key to terminate.");
Console.ReadKey();
