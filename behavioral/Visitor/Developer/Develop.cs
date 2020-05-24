namespace Visitor
{
  // Разработка - конкретное дополнение
  class Develop : IVisitor
  {
    public void Visit(Junior j)
    {
      System.Console.WriteLine("[junior-develop]");
    }
    public void Visit(Senior j)
    {
      System.Console.WriteLine("[senior-develop]");
    }
  }
}