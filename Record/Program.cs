public record TestRecord
{
  public record Person(string name, string[] hobbies);
  public static void Main(string[] args)
  {
    string[] ps = { "1", "2" };
    string[] ps1 = ["1", "2"];
    Person p1 = new Person("1", ps);
    Person p2 = new Person("1", ps);
    Console.WriteLine(ps);
    Console.WriteLine(ps1);

    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(p1 == p2);
    p1.hobbies[0] = "99";
    Console.WriteLine(p1 == p2);
    Console.WriteLine(ReferenceEquals(p1, p2));
    Person p3 = p1 with { name = "p3" };
    Console.WriteLine(p3);
  }
}