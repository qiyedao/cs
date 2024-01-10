int a = 5;
int b = 3;
if (a + b > 10)
{
  Console.WriteLine("The answer is greater than 10");
}
else
{
  Console.WriteLine("The answer is less than 10");
}
int w = 10;
while (w > 0)
{
  // w--;
  --w;
  Console.WriteLine($"w={w}");

}
int d = 10;
do
{
  d--;
  Console.WriteLine($"d = {d}");
} while (d > 0);
for (char c = 'a'; c < 'k'; c++)
{
  Console.WriteLine($"c = {c}");
}
int s = 0;
for (int i = 1; i <= 20; i++)
{
  if (i % 3 == 0 && i >= 3)
  {
    Console.WriteLine($"i= {i}");
    s += i;
  }
}
Console.WriteLine($"s= {s}");