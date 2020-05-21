namespace State
{
  // ВКЛ - конкретное состояние
  class On : IAction
  {
      public void Switch()
      {
        System.Console.WriteLine("[off]");
      }
  }
}