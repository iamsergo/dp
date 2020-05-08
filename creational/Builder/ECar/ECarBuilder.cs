namespace Builder
{
    // Строитель машин
    class ECarBuilder
    {
        private ECar car;
        public ECarBuilder()
        {
            this.car = new ECar();
        }
        public ECar Build()
        {
            return this.car;
        }
        public ECarBuilder SetSeats(int cs)
        {
            this.car.Seats = cs;
            return this;
        }
        public ECarBuilder SetWheel(int cw)
        {
            this.car.Wheel = cw;
            return this;
        }
    }
}