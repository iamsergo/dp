namespace Flyweight
{
  // Окружность - конкретная фигура
  class Circle : IShape
  {
    private int radius;
    public Circle()
    {
      
    }
    public Circle(int radius)
    {
      this.radius = radius;
    }
    public void Draw()
    {
      System.Console.WriteLine($"Circle[{this.radius}]");
    }
  }
}