void workWithStrings()
{
  var names = new List<string> { "z", "y", "c" };
  names.Add("H");
  names.Add("I");
  names.Remove("b");
  foreach (var name in names)
  {
    Console.WriteLine(name.ToUpper());
  }
  Console.WriteLine($"Count: {names.Count}");
  names.Sort();
  foreach (var name in names)
  {
    Console.WriteLine(name.ToUpper());
  }
  Console.WriteLine(names.IndexOf("y"));
}
// workWithStrings();
void workWithFibo()
{
  var fibos = new List<int> { };

  for (int i = 0; i < 20; i++)
  {
    if (i == 0 || i == 1)
    {
      fibos.Add(1);
    }

    else
    {
      fibos.Add(fibos[i - 1] + fibos[i - 2]);
    }
  }
  foreach (var num in fibos)
  {
    Console.WriteLine($"fibo: {num}");
  }
}
workWithFibo();