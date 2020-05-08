namespace Builder
{
    class HomeBuilder
    {
        private Home home;
        public HomeBuilder()
        {
            this.home = new Home();
        }
        public Home Build()
        {
            return this.home;
        }

        public HomeBuilder AddBox()
        {
            this.home.Box = true;
            return this;
        }
        public HomeBuilder AddGarage()
        {
            this.home.Garage = true;
            return this;
        }
        public HomeBuilder AddSwimingPool()
        {
            this.home.SwimingPool = true;
            return this;
        }
        public HomeBuilder AddSauna()
        {
            this.home.Sauna = true;
            return this;
        }
    }
}