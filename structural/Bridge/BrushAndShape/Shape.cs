namespace Bridge
{
    // Общая реализация
    abstract class Shape
    {
        public string Color { get; set; } = "white";
        public IBrush Brush { get; set; }
        public Shape(IBrush brush)
        {
            this.Brush = brush;
        }
        abstract public void Draw();
    }
}