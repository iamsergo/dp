namespace Visitor
{
  // Общий интерфейс разработчика
  interface IDeveloper
  {
    void Accept(IVisitor v);
  }
}