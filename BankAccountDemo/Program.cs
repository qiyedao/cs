// See https://aka.ms/new-console-template for more information
using BankAccountDemo;
try
{
  BankAccount account2 = new BankAccount("qiye", -1000);
}
catch (System.ArgumentOutOfRangeException e)
{

  Console.WriteLine(e.ToString());
}
var account = new BankAccount("qiye", 1000);
account.MakeDeposit(500, DateTime.Now, "Rent payment");
Console.WriteLine($"Account {account.Number} Owner {account.Owner} Balance {account.Balance}");
Console.WriteLine(account.GetAccountHistory());
BankAccount account1 = new BankAccount("qiye", 1000);
account1.MakeWithDrawal(500, DateTime.Now, "withdrawal");
Console.WriteLine($"Account {account1.Number} Owner {account1.Owner} Balance {account1.Balance}");
Console.WriteLine(account1.GetAccountHistory());