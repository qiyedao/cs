// See https://aka.ms/new-console-template for more information
Ball ball = new Ball() { size = 10 };
Basketball basketball = new Basketball(9) { size = 100 };
Console.WriteLine($"Hello, World!{basketball.GetSize()}");
public class Ball
{
  public required int size;
  // public Ball(int _size)
  // {
  //   size = _size;
  // }
  public int GetSize()
  {
    return size;
  }
}
public class Basketball : Ball
{
  // public Basketball(int _size) : base(_size)
  // {

  // }
  public Basketball(int _size)
  {

  }
}