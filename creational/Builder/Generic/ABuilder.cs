namespace Builder
{
    class ABuilder
    {
        private ConcreteProductA p;
        public ABuilder()
        {
            this.p = new ConcreteProductA();
        }

        public ABuilder AddField1()
        {
            return this;
        }
        public ABuilder AddField2()
        {
            return this;
        }

        public ConcreteProductA Build()
        {
            return this.p;
        }
    }
}