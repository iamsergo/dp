namespace Builder
{
    // Машина
    class ECar
    {
        public int Seats { get; set; }
        public int Wheel { get; set; }
        override public string ToString()
        {
            return $"{this.Seats}\n{this.Wheel}";
        }
    }
}