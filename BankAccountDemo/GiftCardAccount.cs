using BankAccountDemo;

public class GiftCardAccount : BankAccount
{
  private readonly decimal _monthlyDeposit = 0m;
  public GiftCardAccount(string name, decimal initialBalance, decimal
 monthlyDeposit = 0) : base(name, initialBalance)
  {
    _monthlyDeposit = monthlyDeposit;
  }
  // public GiftCardAccount(string name, decimal initialBalance, decimal
  // monthlyDeposit = 0) : base(name, initialBalance)
  //  => _monthlyDeposit = monthlyDeposit;
  // public GiftCardAccount(string name, decimal initialBalance) : base(name, initialBalance) { }
  public override void PerformMonthEndTransactions()
  {
    if (_monthlyDeposit != 0)
    {
      base.MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
    }

  }
}