namespace Bridge
{
    class BrushAndShapeApplication
    {
        public void Run()
        {
            var red  = new Red();
            var blue = new Blue();

            var r = new Rectangle(red);
            r = new Rectangle(blue);
            var c = new Circle(blue);

            r.Draw();
            c.Draw();
        }
    }
}