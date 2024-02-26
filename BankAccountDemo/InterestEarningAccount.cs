using BankAccountDemo;

public class InterestEarningAccount : BankAccount
{
  public InterestEarningAccount(string name, decimal amount) : base(name, amount)
  {

  }
  public override void PerformMonthEndTransactions()
  {

    if (Balance > 500m)
    {
      decimal interest = Balance * 0.05m;
      base.MakeDeposit(interest, DateTime.Now, "apply monthly interest");
    }

  }
}