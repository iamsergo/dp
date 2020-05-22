using System.Collections.Generic;

namespace Strategy
{
  // Пузырьковая сортировка - конкретный алгоритм
  class Bubble : ISort
  {
      public void Sort(List<int> list)
      {
        for (int j = 1; j < list.Count; j++)
        {
            for (int i = 0; i < list.Count - j; i++)
            {
                if(list[i] > list[i + 1])
                {
                  int t = list[i];
                  list[i] = list[i+1];
                  list[i+1] = t;
                }
            }
        }
      }
  }
}