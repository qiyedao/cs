// See https://aka.ms/new-console-template for more information
void WorkWithIntegers()
{
  int a = 16;
  int b = 6;
  int c = a / b;
  Console.WriteLine("Hello, World!" + c);

  Console.WriteLine($"a+b={c}");
  double r = 2.5;
  double area = Math.PI * r * r;
  decimal d = 1.0M;
  decimal e = 3.0M;
  Console.WriteLine($"double{area},decimal{d / e}");
  // int input = Console.Read();
  // Console.WriteLine($"input:{input}");

  int a1 = 3;
  int b1 = 2;

  Console.WriteLine($"a1/b1= {a1 / b1}");
  Console.WriteLine($"b1/a1= {b1 / a1}");
  Console.WriteLine($"init max ={int.MaxValue} min= {int.MinValue}");
  // Console.WriteLine($"init max ={(int.MaxValue + 1)} min= {int.MinValue - 1}");

}
WorkWithIntegers();
