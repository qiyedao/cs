int a = 1;
float f = 1.0f;
double d = 1.0;
char c = 'c';
string name = "yi";
bool status = true;
int[] ages = { 18, 20 };
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