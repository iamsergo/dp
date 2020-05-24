namespace Visitor
{
  // Джуниор - конкретный разработчик
  class Junior : IDeveloper
  {
    public void Accept(IVisitor v)
    {
      v.Visit(this);
    }
  }
}