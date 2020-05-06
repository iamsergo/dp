using System;

namespace Factory
{
    // Фабрика дорожных перевозчиков
    class RoadLogistics : Logistics
    {
        private ITransport t;
        public RoadLogistics(string t)
        {
            this.t = t switch
            {
                "car" => new Car(),
                "truck" => new Truck(),
                _ => null
            };
        }
        override public ITransport createTransport()
        {
            return this.t;
        }
    }
}
