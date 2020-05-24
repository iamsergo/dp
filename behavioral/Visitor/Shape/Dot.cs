namespace Visitor
{
  // Точка - конкретная фигура
  class Dot : IShape
  {
    public int X { get; set; }
    public int Y { get; set; }
    public Dot(int x, int y)
    {
      this.X = x;
      this.Y = y;
    }
    public void Draw()
    {
      System.Console.WriteLine("[Dot]");
    }
    public void Accept(IShapeVisitor visitor)
    {
      visitor.visitDot(this);
    }
  }
}