// See https://aka.ms/new-console-template for more information
Basketball basketball = new Basketball(9);
Console.WriteLine($"Hello, World!{basketball.GetSize()}");
public class Ball
{
  private int size;
  public Ball(int _size)
  {
    size = _size;
  }
  public int GetSize()
  {
    return size;
  }
}
public class Basketball : Ball
{
  public Basketball(int _size) : base(_size)
  {

  }
}