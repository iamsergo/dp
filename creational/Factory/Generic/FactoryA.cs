using System;

namespace Factory
{
    class FactoryA : Factory
    {
        override public IProduct CreateProduct()
        {
            return new ConcreteProductA();
        }
    }
}
