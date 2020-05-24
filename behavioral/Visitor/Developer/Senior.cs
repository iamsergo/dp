namespace Visitor
{
  // Сеньор - конкретный разработчик
  class Senior : IDeveloper
  {
    public void Accept(IVisitor v)
    {
      v.Visit(this);
    }
  }
}