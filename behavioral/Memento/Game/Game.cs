namespace Memento
{
    // Игра - создатель
    class Game
    {
        private int level;
        public void AddLevel()
        {
            System.Console.WriteLine($"{this.level} -> {++this.level}");
        }

        public void SetLevel(int level)
        {
            System.Console.WriteLine($"{this.level} -> {this.level = level}");
        }
        public Saver Save()
        {
            return new Saver(this, this.level);
        }
        override public string ToString()
        {
            return $"Level : [{this.level}]";
        }
    }
}