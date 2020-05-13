namespace Composite
{
    // Элементарный компонент
    class Dot : IGraphic
    {
        private int x;
        private int y;
        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Draw()
        {
            System.Console.WriteLine($"Dot drawed [{this.x};{this.y}]!");
        }
        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
            System.Console.WriteLine($"Dot[{this.x};{this.y}]");
        }
    }
}