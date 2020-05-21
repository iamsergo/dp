namespace State
{
  // Состояние проигрывателя : проигрывание, готовность, блокировка
  abstract class PlayerState
  {
    protected Player player;
    public PlayerState(Player player)
    {
      this.player = player;
    }
    abstract public void Lock();
    abstract public void Play();
    virtual public void Next() {
      this.player.Next();
    }
    virtual public void Prev() {
      this.player.Prev();
    }
  }
}