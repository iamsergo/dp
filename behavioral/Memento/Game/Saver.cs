namespace Memento
{
    // Сохранитель - снимок
    class Saver
    {
        private Game game;
        private int level;
        public Saver(Game game, int level)
        {
            this.game = game;
            this.level = level;
        }
        public void Restore()
        {
            this.game.SetLevel(this.level);
        }
    }
}