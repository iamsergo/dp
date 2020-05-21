namespace State
{
  // Проирывание - конкретное состояние
  class Playing : PlayerState
  {
    public Playing(Player player) : base(player) {}
    override public void Lock()
    {
      this.player.SetState(new Locked(this.player));
    }
    override public void Play()
    {
      this.player.StopPlay();
      this.player.SetState(new Ready(this.player));
    }
  }
}