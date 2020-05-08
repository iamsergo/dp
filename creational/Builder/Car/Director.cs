namespace Builder
{
    // Директор - знает что надо делать
    class Director
    {
        public void Make(IBuilder b)
        {
            b.Reset();
            b.SetSeats(2);
            b.SetWheel(4);
        }
    }
}