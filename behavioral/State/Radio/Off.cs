namespace State
{
  // ВЫКЛ - конкретное состояние
  class Off : IAction
  {
      public void Switch()
      {
        System.Console.WriteLine("[on]");
      }
  }
}