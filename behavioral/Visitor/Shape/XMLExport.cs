namespace Visitor
{
  // Експорт в XML - конкретный посетитель
  class XMLExport : IShapeVisitor
  {
      public void visitDot(Dot dot)
      {
        System.Console.WriteLine($"<dot x={dot.X} y={dot.Y} />");
      }
      public void visitRectangle(Rectangle rect)
      {
        System.Console.WriteLine($"<rectangle width={rect.Width} height={rect.Height}/>");
      }
  }
}