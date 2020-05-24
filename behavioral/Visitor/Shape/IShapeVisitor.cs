namespace Visitor
{
  // Общий интерфейс посетителей
  interface IShapeVisitor
  {
    void visitDot(Dot dot);
    void visitRectangle(Rectangle rect);
  }
}