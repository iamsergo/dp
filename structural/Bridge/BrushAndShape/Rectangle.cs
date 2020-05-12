namespace Bridge
{
    // Прямоугольник - конкретная абстракция
    class Rectangle : Shape
    {
        public Rectangle(IBrush brush) : base(brush) {}
        override public void Draw()
        {
            this.Brush.Draw(this);
            System.Console.WriteLine(this.Color + " rectangle");
        }
    }
}