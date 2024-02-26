using BankAccountDemo;
public class LineOfCreditAccount : BankAccount
{
  public LineOfCreditAccount(string name, decimal amount, decimal creditLimit) : base(name, amount, -creditLimit)
  {

  }
  public override void PerformMonthEndTransactions()
  {
    if (Balance < 0)
    {
      // Negate the balance to get a positive interest charge:
      decimal interest = -Balance * 0.07m;
      base.MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
    }

  }
  protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
 isOverdrawn
 ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
 : default;

}