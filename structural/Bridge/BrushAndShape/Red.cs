namespace Bridge
{
    // Красный - конкретная реализация
    class Red : IBrush
    {
        public void Draw(Shape s)
        {
            s.Color = "red";
        }
    }
}