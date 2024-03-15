public enum PublicationType { Misc, Book, Magazine, Article };
public abstract class Publication
{
  public bool _published;
  public DateTime datePublished;
  public int totalPages;
  public string Title { get; }
  public string Publisher { get; }
  public PublicationType Type { get; }
  public Publication(string title, string publisher, PublicationType publicationType)
  {
    if (string.IsNullOrWhiteSpace(title))
    {
      throw new ArgumentException("title is required");
    }
    else
    {
      Title = title;
    }
    if (string.IsNullOrWhiteSpace(publisher))
    {
      throw new ArgumentException("publisher is required");
    }
    else
    {
      Publisher = publisher;
    }
    Type = publicationType

  }
  public string? CopyrightName { get; private set; }
  public string CopyrightDate { get; private set; }

  public int pages
  {
    get { return totalPages; }
    set
    {
      if (value < 0)
      {
        throw new ArgumentOutOfRangeException(nameof(value), "The number of pages cannot be zero or negative.");
        totalPages = value;
      }
    }
  }

  public string GetPublishedDate()
  {

    if (!_published)
      return "NYP";
    else
      return datePublished.ToString("d");

  }
  public void Publish(DateTime datePublished)
  {
    _published = true;
    this.datePublished = datePublished;
  }
  public void Copyright(string copyrightName, int copyrightDate)
  {
    if (string.IsNullOrWhiteSpace(copyrightName))
      throw new ArgumentException("The name of the copyright holder is required.");
    CopyrightName = copyrightName;
    int currentYear = DateTime.Now.Year;
    if (copyrightDate < currentYear - 10 || copyrightDate > currentYear + 2)
      throw new ArgumentOutOfRangeException($"The copyright year must be between {currentYear - 10} and {currentYear + 1}");
    CopyrightDate = copyrightDate;
  }
  public override string ToString() => Title;
}