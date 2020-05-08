namespace Builder
{
    // Строитель руководства к машине
    class CarManualBuilder : IBuilder
    {
        private CarManual cm;
        public void Reset()
        {
            this.cm = new CarManual();
        }
        public void SetSeats(int cs)
        {
            this.cm.Seats = $"Car with {cs} seats.";
            System.Console.WriteLine(this.cm.Seats);
        }
        public void SetWheel(int cw)
        {
            this.cm.Wheel = $"Car with {cw} wheels";
            System.Console.WriteLine(this.cm.Wheel);
        }
        public CarManual Build()
        {
            System.Console.WriteLine("CarManual builded!");
            return this.cm;
        }
    }
}