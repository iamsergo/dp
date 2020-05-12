namespace Bridge
{
    // Окружность - конкретная абстракция
    class Circle : Shape
    {
        public Circle(IBrush brush) : base(brush) {}
        override public void Draw()
        {
            this.Brush.Draw(this);
            System.Console.WriteLine(this.Color + " circle");
        }
    }
}