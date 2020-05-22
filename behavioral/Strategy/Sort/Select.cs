using System.Collections.Generic;

namespace Strategy
{
  // Сортировка выбором - конкретный алгоритм
  class Select : ISort
  {
      public void Sort(List<int> list)
      {
        int i, j, z;
        for (i = 1; i < list.Count; i++)
        {
          z = list[i];
          for (j = i - 1; j >= 0 && list[j] > z; j--)
          {
            list[j+1] = list[j];
          }
          list[j+1] = z;
        }
      }
  }
}