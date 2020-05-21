namespace State
{
  class LightApplication
  {
      public void Run()
      {
        Light l = new Light();
        l.SetState(new Off());

        l.Switch();
        l.Switch();
        l.Switch();
      }
  }
}