namespace Visitor
{
  // Общий интерфейс посетителя
  interface IVisitor
  {
    void Visit(Junior j);
    void Visit(Senior s);
  }
}