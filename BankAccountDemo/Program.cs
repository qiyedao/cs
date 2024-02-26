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
var account1 = new BankAccount("qiye", 1000);
account1.MakeWithdrawal(500, DateTime.Now, "withdrawal");
Console.WriteLine($"Account {account1.Number} Owner {account1.Owner} Balance {account1.Balance}");
Console.WriteLine(account1.GetAccountHistory());

var giftCard = new GiftCardAccount("gift card", 100, 50);
giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
giftCard.PerformMonthEndTransactions();
// can make additional deposits:
giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spendingmoney");
Console.WriteLine(giftCard.GetAccountHistory());

var savings = new InterestEarningAccount("savings account", 10000);
savings.MakeDeposit(750, DateTime.Now, "save some money");
savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
savings.PerformMonthEndTransactions();
Console.WriteLine(savings.GetAccountHistory());

var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
// How much is too much to borrow?
lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
lineOfCredit.PerformMonthEndTransactions();
Console.WriteLine(lineOfCredit.GetAccountHistory());
