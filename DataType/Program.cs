using TestDataType;

string s = "999" + 5.ToString();
Console.WriteLine(s.GetType());
TestDataTypeClass t = new TestDataTypeClass();
Console.WriteLine(t.GetF());
int a = 1;
float f = 1.0f;
double d = 1.0;
char c = 'c';
string name = "yi";
bool status = true;
int[] ages = { 18, 20 };
int[] heights = [1, 2, 3, 5];
char[] chars = { 'a', 'b' };
string[] names = { "a", "b" };
bool[] payInfo = { true, false };
var limit = 3;
int[] source = { 0, 1, 2, 3, 4, 5 };
var query = from item in source
            where item <= limit
            select item;
foreach (var q in query)
{
  Console.WriteLine($"q: {q}");
}
byte b = byte.MaxValue;
Console.WriteLine(b);
public struct Coords
{
  private int x;
  private int y;
  public Coords(int p1, int p2)
  {
    x = p1;
    y = p2;
  }
}

public enum OrderStatus
{
  waiting = 1,
  paid = 2,
  express = 3
}

namespace TestDataType
{
  public class TestDataTypeClass
  {
    private int f = 100000;

    public int GetF()
    {
      return f;
    }
  }
}