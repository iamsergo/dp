namespace Builder
{
    // Строитель машин
    class CarBuilder : IBuilder
    {
        private Car car;
        public void Reset()
        {
            this.car = new Car();
        }
        public void SetSeats(int cs)
        {
            this.car.Seats = cs;
            System.Console.WriteLine(this.car.Seats);
        }
        public void SetWheel(int cw)
        {
            this.car.Wheel = cw;
            System.Console.WriteLine(this.car.Wheel);
        }
        public Car Build()
        {
            System.Console.WriteLine("Car builded!");
            return this.car;
        }
    }
}