namespace BankAccountDemo;
public class BankAccount
{
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
  public BankAccount(string name, decimal initialBalance)
  {
    // this.Owner = name;
    // this.Balance = initialBalance
    Owner = name;
    // Balance = initialBalance;
    MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
    this.Number = accountNumberSeed.ToString();
    accountNumberSeed++;
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
  public void MakeWithDrawal(decimal amount, DateTime date, string note)
  {
    if (amount < 0)
    {
      throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
    }
    if (Balance - amount < 0)
    {
      throw new InvalidOperationException("Not sufficient funds for this withdrawal");
    }
    var withdrawal = new Transaction(-amount, date, note);
    transactions.Add(withdrawal);
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
}