namespace Builder
{
    class Application
    {
        public void Run()
        {
            Director d = new Director();

            CarBuilder cb = new CarBuilder();
            d.Make(cb);
            Car car = cb.Build();

            CarManualBuilder cmb = new CarManualBuilder();
            d.Make(cmb);
            CarManual cm = cmb.Build();
        }
    }
}