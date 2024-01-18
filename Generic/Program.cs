// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
GenericList<TestGeneric> genericList = new GenericList<TestGeneric>();
genericList.add(new TestGeneric());
GenericList<int> g = new GenericList<int>();
g.add(100);
// 匿名类型
var a = new { name = "999", age = "99" };
Console.WriteLine(a.name);
public class GenericList<T>
{
  public void add(T input)
  {

  }
}
public class TestGeneric
{

}
