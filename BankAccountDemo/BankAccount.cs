namespace BankAccountDemo;
public class BankAccount
{
  private readonly decimal _minimumBalance;
  private static int accountNumberSeed = 123456789;
  public string Number { get; }
  public string Owner { get; set; }
  public decimal Balance
  {
    get
    {
      decimal balance = 0;
      foreach (var item in transactions)
      {
        balance += item.Amount;
      }
      return balance;
    }
  }
  private List<Transaction> transactions = new List<Transaction>();
  public virtual void PerformMonthEndTransactions() { }
  // public BankAccount(string name, decimal initialBalance)
  // {
  //   // this.Owner = name;
  //   // this.Balance = initialBalance
  //   Owner = name;
  //   // Balance = initialBalance;
  //   MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
  //   this.Number = accountNumberSeed.ToString();
  //   accountNumberSeed++;
  // }
  public BankAccount(string name, decimal initialBalance) : this(name,
initialBalance, 0)
  { }
  public BankAccount(string name, decimal initialBalance, decimal
  minimumBalance)
  {
    Number = accountNumberSeed.ToString();
    accountNumberSeed++;
    Owner = name;
    _minimumBalance = minimumBalance;
    if (initialBalance > 0)
      MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
  }

  public void MakeDeposit(decimal amount, DateTime date, string note)
  {
    if (amount < 0)
    {
      throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
    }
    var deposit = new Transaction(amount, date, note);
    transactions.Add(deposit);
  }
  public void MakeWithdrawal(decimal amount, DateTime date, string note)
  {
    if (amount < 0)
    {
      throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
    }
    Transaction? overdraftTransaction = CheckWithdrawalLimit(Balance -
 amount < _minimumBalance);
    Transaction? withdrawal = new(-amount, date, note);
    transactions.Add(withdrawal);
    if (overdraftTransaction != null)
      transactions.Add(overdraftTransaction);
  }

  public string GetAccountHistory()
  {
    var report = new System.Text.StringBuilder();
    decimal balance = 0;
    report.AppendLine("Date\t\tAmount\tBalance\tNote");
    foreach (var item in transactions)
    {
      balance += item.Amount;
      report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Note}");
    }
    return report.ToString();


  }

  protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
  {
    if (isOverdrawn)
    {
      throw new InvalidOperationException("Not sufficient funds for this withdrawal");
    }
    else
    {
      return default;
    }
  }
}