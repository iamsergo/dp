namespace Builder
{
    // Продукт - описывает все поля
    class Home
    {
        public bool Box { get; set; }
        public bool SwimingPool { get; set; }
        public bool Garage { get; set; }
        public bool Sauna { get; set; }
        override public string ToString()
        {
            string b  = "\n" + (this.Box ? "box" : "");
            string sw = "\n" + (this.SwimingPool ? "swimingpool" : "");
            string g  = "\n" + (this.Garage ? "garage" : "");
            string s  = "\n" + (this.Sauna ? "sauna" : "");
            return $"{b}{sw}{g}{s}";
        }
    }
}