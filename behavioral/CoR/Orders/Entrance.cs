namespace CoR
{
    class Entrance : ILogin
    {
        private ILogin nl;
        public ILogin SetNext(ILogin nl)
        {
            this.nl = nl;
            return this.nl;
        }
        public void Handle(string password)
        {
            System.Console.WriteLine("[Entrance]");
            System.Console.WriteLine("Entrance success!");
        }
    }
}