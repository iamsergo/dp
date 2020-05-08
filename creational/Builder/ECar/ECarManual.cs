namespace Builder
{
    // Руководство
    class ECarManual
    {
        public string Seats { get; set; }
        public string Wheel { get; set; }
        override public string ToString()
        {
            return $"{this.Seats}\n{this.Wheel}";
        }
    }
    
}