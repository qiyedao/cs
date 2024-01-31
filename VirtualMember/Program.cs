// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Square square = new Square();
square.draw();
Shape shape = new Square();
shape.draw();
Shape shape1 = new Shape();
shape1.draw();
Shape shape2 = (Shape)new Square();
shape2.draw();
public class Shape
{
  public virtual void draw()
  {
    Console.WriteLine("Base Shape");
  }
}
public class Square : Shape
{
  public override void draw()
  {
    Console.WriteLine("Draw Square");
  }
}