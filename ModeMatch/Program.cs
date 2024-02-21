// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int? a = 1;
int? b = null;
if (a is int)
{
  Console.WriteLine("int");
}
if (a is not null)
{
  Console.WriteLine("not null");
}
if (b is null)
{
  Console.WriteLine("null");
}