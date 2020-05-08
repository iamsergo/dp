namespace Builder
{
    class App
    {
        public void Run()
        {
            ABuilder ab = new ABuilder();
            ab
             .AddField1()
             .AddField2();
            ConcreteProductA a = ab.Build();
        }
    }
}