namespace Prototype
{
    // Конкретная фигура
    class Rectangle : Shape, ICloneable<Rectangle>
    {
        private int width;
        private int height;
        public Rectangle(int width, int height)
        {
            this.width  = width;
            this.height = height;
        }
        public Rectangle(Rectangle source) : base(source)
        {
            this.width  = source.width;
            this.height = source.height;
        }
        public Rectangle Clone()
        {
            return new Rectangle(this);
        }
        override public string ToString()
        {
            return $"{this.x} {this.y} {this.width} {this.height}";
        }
    }
}