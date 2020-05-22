namespace Strategy
{
  // Сложение - конкретный алгоритм
  class Additional : IAlgo
  {
      public void Execute(int a, int b)
      {
        System.Console.WriteLine($"[add] : {a + b}");
      }
  }
}