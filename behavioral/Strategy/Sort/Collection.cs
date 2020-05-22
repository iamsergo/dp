using System.Collections.Generic;

namespace Strategy
{
  // Коллекция - контекст
  class Collection
  {
      private List<int> list;
      private ISort sort;
      public Collection(List<int> list)
      {
        this.list = list;
      }
      public void SetSort(ISort sort)
      {
        this.sort = sort;
      }
      public void Sort()
      {
        this.sort.Sort(this.list);
        foreach (var i in this.list)
        {
          System.Console.Write(i + " ");
        }
      }
  }
}