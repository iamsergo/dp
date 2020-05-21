namespace State
{
  // Свет - контекст
  class Light
  {
    // private bool light;
    private IAction state;
    public void SetState(IAction newState)
    {
      this.state = newState;
    }
    public void Switch()
    {
      this.state.Switch();
      this.SetState(
        this.state.GetType().Name == "Off"
          ? (IAction)new On()
          : (IAction)new Off()
      );
    }
  }
}