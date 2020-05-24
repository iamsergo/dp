namespace Visitor
{
  // Тесты - конкретное дополнение
  class Test : IVisitor
  {
    public void Visit(Junior j)
    {
      System.Console.WriteLine("[junior-test]");
    }
    public void Visit(Senior s)
    {
      System.Console.WriteLine("[senior-test]");
    }
  }
}