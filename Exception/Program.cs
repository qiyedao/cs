// See https://aka.ms/new-console-template for more information
// 一个不具有 catch 或 finally 块的 try 块会导致编译器错误。
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

//when 筛选条件
// try
// {
//   return array[index];
// }
// catch (IndexOutOfRangeException e) when (index < 0)
// {
//   throw new ArgumentOutOfRangeException(
//   "Parameter index cannot be negative.", e);
// }
// catch (IndexOutOfRangeException e)
// {
//   throw new ArgumentOutOfRangeException(
//   "Parameter index cannot be greater than the array size.", e);
// }
FileStream? file = null;
FileInfo fileinfo = new System.IO.FileInfo("./file.txt");
try
{
  file = fileinfo.OpenWrite();
  file.WriteByte(0xF);
}
finally
{
  // Check for null because OpenWrite might have failed.
  file?.Close();
}

public class CustomException : Exception
{
  public CustomException(string message)
  {

  }
}
