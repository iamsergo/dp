namespace CoR
{
    interface ILogin
    {
        ILogin SetNext(ILogin nl);
        void Handle(string password);
    }
}