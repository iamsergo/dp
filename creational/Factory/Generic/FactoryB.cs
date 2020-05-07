using System;

namespace Factory
{
    class FactoryB : Factory
    {
        override public IProduct CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}
