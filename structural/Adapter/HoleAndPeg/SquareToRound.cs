namespace Adapter
{
    // Адаптер - квадрат --> круг
    class SquareToRound : RoundPeg
    {
        private SquarePeg sp;
        public SquareToRound(SquarePeg sp)
            : base((sp.Width * System.Math.Sqrt(2)) / 2)
        {
            this.sp = sp;
        }
    }
}