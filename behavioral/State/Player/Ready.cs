namespace State
{
  // Готовность - конкретное состояние
  class Ready : PlayerState
  {
    public Ready(Player player) : base(player) { }
    override public void Lock()
    {
      this.player.SetState(new Locked(this.player));
      System.Console.WriteLine("Locked...");
    }
    override public void Play()
    {
      this.player.StartPlay();
      this.player.SetState(new Playing(this.player));
    }
  }
}