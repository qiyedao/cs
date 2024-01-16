// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
GenericList<TestGeneric> genericList = new GenericList<TestGeneric>();
genericList.add(new TestGeneric());
GenericList<int> g = new GenericList<int>();
g.add(100);
public class GenericList<T>
{
  public void add(T input)
  {

  }
}
public class TestGeneric
{

}