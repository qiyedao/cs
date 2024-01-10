// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
await Task.Delay(1000);
Console.WriteLine(args.Length);
string? s = Console.ReadLine();
int returnValue = int.Parse(s ?? "-1");
Console.WriteLine(returnValue);
return returnValue;
