// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void TestFinally()
{
  throw new CustomException("CustomException");
}
try
{
  TestFinally();
}
catch (CustomException ex)
{
  Console.WriteLine(ex.ToString());
}
finally
{
  Console.WriteLine("done");
}
public class CustomException : Exception
{
  public CustomException(string message)
  {

  }
}
