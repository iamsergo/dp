namespace Memento
{
    class GameApplication
    {
        public void Run()
        {
            Game g = new Game();
            g.AddLevel();
            g.AddLevel();            

            Saver s = g.Save();

            g.AddLevel();
            System.Console.WriteLine(g.ToString());
            
            s.Restore();
            System.Console.WriteLine(g.ToString());
        }
    }
}