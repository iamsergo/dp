namespace CoR
{
    // Базовый оператор - помогает с узкими проблемами
    class Base : IResponse
    {
        private IResponse nr;
        public void SetNext(IResponse nr)
        {
            this.nr = nr;
        }
        public void Handle(string req)
        {
            if (req == "not undestand")
            {
                System.Console.WriteLine("[Base] ->");
                nr.Handle(req);
            }
            else
            {
                System.Console.WriteLine("[Base] : Task is done!");
            }
        }
    }
}