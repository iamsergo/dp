namespace CoR
{
    // Авто-оператор - помогает с общими проблемами
    class Auto : IResponse
    {
        private IResponse nr;
        public void SetNext(IResponse nr)
        {
            this.nr = nr;
        }
        public void Handle(string req)
        {
            if(req == "not undestand")
            {
                System.Console.WriteLine("[Auto] ->");
                nr.Handle(req);
            }
            else
            {
                System.Console.WriteLine("[Auto] : Task is done!");
            }
        }
    }
}