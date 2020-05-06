using System;

namespace Factory
{
    class LogisticApp
    {
        private Logistics t;
        public LogisticApp(string type)
        {
            this.t = type switch
            {
                "car" => new RoadLogistics(type),
                "ship" => new RoadLogistics(type),
                "sea" => new SeaLogistics(),
                _ => null
            };
        }
        public void Run()
        {
            this.t.Run();
        }
    }
}
