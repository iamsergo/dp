namespace Visitor
{
  class ShapeApplication
  {
    public void Run()
    {
      Dot d1 = new Dot(0,0);
      Dot d2 = new Dot(1,2);
      Rectangle r = new Rectangle(1,5);

      XMLExport xe = new XMLExport();

      d1.Accept(xe);
      d2.Accept(xe);
      r.Accept(xe);
    }
  }
}