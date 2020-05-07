namespace AbstractFactory
{
    class App
    {
        private IFactory f;
        private IProductA a;
        private IProductB b;
        public App(IFactory f)
        {
            this.f = f;
        }
        public void Init()
        {
            this.a = this.f.CreateProductA();
            this.b = this.f.CreateProductB();
        }
        public void Run()
        {
            this.a.Method();
            this.b.Method();
        }
    }
}