namespace Bridge
{
    class Blue : IBrush
    {
        public void Draw(Shape s)
        {
            s.Color = "blue";
        }
    }
}