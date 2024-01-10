// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class TestClass
{
  // public static void Main() { }
  // public static int Main() { }
  // public static void Main(string[] args) { }
  // public static int Main(string[] args) { }
  // public static async Task Main() { }
  // public static async Task<int> Main() { }
  // public static async Task Main(string[] args) { }
  // public static async Task<int> Main(string[] args) { }
  // static void Main(string[] args)
  // {
  //   Console.WriteLine("Main");
  // }
  static int Main()
  {

    AsyncConsoleWork().GetAwaiter().GetResult();
  }
  private static async Task<int> AsyncConsoleWork()
  {
    // Main body here
    return 0;
  }


}
