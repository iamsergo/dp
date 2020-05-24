namespace Visitor
{
  // Фигура - общий интерфейс
  interface IShape
  {
    void Draw();
    void Accept(IShapeVisitor vis);
  }
}