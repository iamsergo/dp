using System;

namespace Factory
{
    class Application
    {
        private Factory f;
        public Application(string type)
        {
            this.f = type switch
            {
                "a" => new FactoryA(),
                "b" => new FactoryB(),
                _   => null 
            };
        }
        public void Run()
        {
            this.f.Method();
        }
    }
}
