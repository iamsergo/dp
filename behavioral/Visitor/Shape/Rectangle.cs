namespace Visitor
{
  // Прямоугольник - конкретная фигура
  class Rectangle : IShape
  {
    public int Width { get; set; }
    public int Height { get; set; }
    public Rectangle(int w, int h)
    {
      this.Width  = w;
      this.Height = h;
    }
    public void Draw()
    {
      System.Console.WriteLine("[Rectangle]");
    }
    public void Accept(IShapeVisitor visitor)
    {
      visitor.visitRectangle(this);
    }
  }
}