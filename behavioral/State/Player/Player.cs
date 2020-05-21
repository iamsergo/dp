namespace State
{
  // Проигрыватель - контекст
  class Player
  {
    private PlayerState state;
    public bool Playing { get; set; } = true;
    public void SetState(PlayerState newState)
    {
      this.state = newState;
    }
    public void Lock()
    {
      this.state.Lock();
    }
    public void Play()
    {
      this.state.Play();
    }
    public void Next()
    {
      System.Console.WriteLine("[next]");
    }
    public void Prev()
    {
      System.Console.WriteLine("[prev]");
    }
    public void StartPlay()
    {
      System.Console.WriteLine("[start]");
    }
    public void StopPlay()
    {
      System.Console.WriteLine("[play]");
    }
  }
}