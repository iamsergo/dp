namespace Adapter
{
    // Круглое отверстие - работает только с круглыми колышками
    class RoundHole
    {
        private double radius;
        public RoundHole(double radius)
        {
            this.radius = radius;
        }
        public void Put(RoundPeg rp)
        {
            System.Console.WriteLine(
                this.radius > rp.Radius ? "yes" : "no"
            );
        }
    }
}