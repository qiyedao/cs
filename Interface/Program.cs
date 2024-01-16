// See https://aka.ms/new-console-template for more information
Car car1 = new Car();
car1.Year = "2023";
Car car2 = new Car();
car2.Year = "2024";
Console.WriteLine(car1.Equals(car2));
Console.WriteLine("Hello, World!");

interface ICar<T>
{
  bool Equals(T obj);
}
public class Car : ICar<Car>
{
  public string? Make
  {
    get; set;
  }
  public string? Model
  {
    get; set;
  }
  public string? Year
  {
    get; set;
  }

  public bool Equals(Car? car)
  {

    return (this.Make, this.Model, this.Year) ==
    (car?.Make, car?.Model, car?.Year);

  }

}