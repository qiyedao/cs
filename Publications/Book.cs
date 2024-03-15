using System;

// 不允许被继承
public class sealed Book : Pblication
{
    public Book(string title, string author, string publisher) :
     this(title, string.Empty, author, publisher)
     { }

public Book(string title, string isbn, string author, string publisher)
    : base(title, publisher, PublicationType.Book)
     {

  if (!string.IsNullOrEmpty(isbn))
  {
    // Determine if ISBN length is correct.
    if (!(isbn.Length == 10 | isbn.Length == 13))
      throw new ArgumentException("The ISBN must be a 10- or 13-character numeric string.");
    if (!ulong.TryParse(isbn, out _))
      throw new ArgumentException("The ISBN can consist of numeric characters only.");
  }
  ISBN = isbn;
  Author = author;
}
public string ISBN { get; }
public string Author { get; }
public decimal Price { get; private set; }
public string? Currency { get; private set; }
public decimal SetPrice(decimal price, string currency)
{
  if (price < 0)
    throw new ArgumentOutOfRangeException(nameof(price), "The price cannot be negative.");
  decimal oldValue = Price;
  Price = price;
  if (currency.Length != 3)
    throw new ArgumentException("The ISO currency symbol is a 3-character string.");
  Currency = currency;
  return oldValue;
}
public override bool Equals(object? obj)
{
  if (obj is not Book book)
    return false;
  else
    return ISBN == book.ISBN;
}

public override int GetHashCode() => ISBN.GetHashCode();
public override string ToString() => $"{(string.IsNullOrEmpty(Author) ? "" : Author + ", ")}{Title}";

}