namespace State
{
  // Блокировка - конкретное состояние
  class Locked : PlayerState
  {
    public Locked(Player player) : base(player)
    {
      this.player.Playing = false;
    }
    override public void Lock()
    {
      this.player.SetState(
        this.player.Playing
          ? (PlayerState)new Playing(this.player)
          : (PlayerState)new Ready(this.player)
      );
      System.Console.WriteLine("Stop playing");
    }
    override public void Play()
    {
      System.Console.WriteLine("Locked...");
    }
    override public void Next()
    {
      System.Console.WriteLine("Locked...");
    }
    override public void Prev()
    {
      System.Console.WriteLine("Locked...");
    }
  }
}