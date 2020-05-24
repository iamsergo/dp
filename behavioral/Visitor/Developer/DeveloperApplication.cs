using System.Collections.Generic;

namespace Visitor
{
  class DeveloperApplication
  {
    public void Run()
    {
      List<IDeveloper> ds = new List<IDeveloper>(){
        new Junior(), new Senior()
      };

      foreach (var d in ds)
      {
        d.Accept(new Test());
        d.Accept(new Develop());
      }
    }
  }
}