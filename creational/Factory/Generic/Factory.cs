using System;

namespace Factory
{
    // Общий интерфейс фабрики
    abstract class Factory
    {
        public void Method()
        {
            IProduct p = this.CreateProduct();
            p.Method();
        }
        abstract public IProduct CreateProduct();
    }
}
