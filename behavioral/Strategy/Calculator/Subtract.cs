namespace Strategy
{
  // Вычитание - конкретный алгоритм
  class Subtract : IAlgo
  {
      public void Execute(int a, int b)
      {
        System.Console.WriteLine($"[sub] : {a - b}");
      }
  }
}