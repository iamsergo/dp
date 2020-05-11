namespace CoR
{
    class Authentication : ILogin
    {
        private ILogin nl;
        public ILogin SetNext(ILogin nl)
        {
            this.nl = nl;
            return nl;
        }
        public void Handle(string password)
        {            
            if(password == "123")
            {
                System.Console.WriteLine("[Authentication-success] ->");
                this.nl.Handle(password);
            }
            else
            {
                System.Console.WriteLine("[Authentification-error]");
            }
        }
    }
}