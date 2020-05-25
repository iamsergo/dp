using System.Collections.Generic;

namespace Flyweight
{
  class ShapeApplication
  {
    public void Run()
    {
      ShapeFactory sf = new ShapeFactory();

      List<IShape> ss = new List<IShape>();

      ss.Add(sf.GetShape("rectangle"));
      ss.Add(sf.GetShape("rectangle"));
      ss.Add(sf.GetShape("circle"));

      foreach (var s in ss)
      {
        s.Draw();
      }
    }
  }
}