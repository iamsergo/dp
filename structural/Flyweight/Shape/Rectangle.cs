namespace Flyweight
{
  // Прямоугольник - конкретная фигура
  class Rectangle : IShape
  {
    private int width;
    private int height;
    public Rectangle()
    {
      
    }
    public Rectangle(int width, int height)
    {
      this.width = width;
      this.height = height;
    }
    public void Draw()
    {
      System.Console.WriteLine($"Rect[{this.width}{this.height}]");
    }
  }
}