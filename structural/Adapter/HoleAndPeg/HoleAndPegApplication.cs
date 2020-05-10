namespace Adapter
{
    class HoleAndPegApplication
    {
        public void Run()
        {
            RoundHole rh = new RoundHole(5);

            RoundPeg rp = new RoundPeg(4);
            rh.Put(rp);

            SquarePeg sp = new SquarePeg(1);

            RoundPeg str = new SquareToRound(sp);
            rh.Put(str);
        }
    }
}