namespace CoR
{
    class Authorization : ILogin
    {
        private ILogin nl;
        public ILogin SetNext(ILogin nl)
        {
            this.nl = nl;
            return this.nl;
        }
        public void Handle(string password)
        {
            System.Console.WriteLine("[Authorization->]");
            this.nl.Handle(password);
        }
    }
}