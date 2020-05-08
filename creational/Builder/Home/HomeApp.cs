namespace Builder
{
    class HomeApp
    {
        public void Run()
        {
            HomeBuilder hb = new HomeBuilder();
            hb
             .AddBox()
             .AddGarage()
             .AddSauna()
             .AddSwimingPool();

            Home home = hb.Build();

            System.Console.WriteLine(home);
        }
    }
}