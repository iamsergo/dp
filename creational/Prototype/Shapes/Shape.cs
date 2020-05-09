namespace Prototype
{
    // Общий интерфейс фигур
    abstract class Shape
    {
        protected int x;
        protected int y;
        public Shape(){}
        public Shape(Shape source) : this()
        {
            this.x = source.x;
            this.y = source.y;
        }
    }
}