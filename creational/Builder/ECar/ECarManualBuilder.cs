namespace Builder
{
    // Строитель руководства к машине
    class ECarManualBuilder
    {
        private ECarManual cm;
        public ECarManualBuilder()
        {
            this.cm = new ECarManual();
        }
        public ECarManualBuilder SetSeats(int cs)
        {
            this.cm.Seats = $"Car with {cs} seats";
            return this;
        }
        public ECarManualBuilder SetWheel(int cw)
        {
            this.cm.Wheel = $"Car with {cw} wheels";
            return this;
        }
        public ECarManual Build()
        {
            return this.cm;
        }
    }
}