namespace Adapter
{
    // Круглый колышек - приемлимый объект
    class RoundPeg
    {
        private double radius;
        public double Radius { get { return this.radius; } }
        public RoundPeg(double radius)
        {
            this.radius = radius;
        }
    }
}