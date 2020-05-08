namespace Builder
{
    class EApplication
    {
        public void Run()
        {
            ECarBuilder cb = new ECarBuilder().SetSeats(2).SetWheel(4);
            ECar car = cb.Build();
            System.Console.WriteLine(car);

            ECarManualBuilder cmb = new ECarManualBuilder().SetSeats(2).SetWheel(4);
            ECarManual cm = cmb.Build();
            System.Console.WriteLine(cm);
        }
    }
}