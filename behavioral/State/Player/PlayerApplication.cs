namespace State
{
    class PlayerApplication
    {
      public void Run()
      {
        Player p = new Player();
        PlayerState ps = new Playing(p);

        p.Next();
        p.Next();
        p.Prev();
        p.StopPlay();
        // p.StartPlay();
        // p.Lock();
        // p.Play();
      }
    }
}