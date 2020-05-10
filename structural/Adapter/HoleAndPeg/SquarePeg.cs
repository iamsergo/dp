namespace Adapter
{
    // Квадратный колышек - неподходящий объект
    class SquarePeg
    {
        private double width;
        public double Width { get { return this.width; } }
        public SquarePeg(double width)
        {
            this.width = width;
        }
    }
}