using System.Collections.Generic;

namespace Strategy
{
  class SortApplication
  {
    public void Run()
    {
      Collection col = new Collection(new List<int>(){ 1, 2, 3, 4, 3, 2, 1, 0});

      // col.SetSort(new Bubble());
      col.SetSort(new Select());

      col.Sort();
    }
  }
}