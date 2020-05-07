using System;

namespace Factory
{
    // Конкретный продукт
    class ConcreteProductA : IProduct
    {
        public void Method()
        {
            System.Console.WriteLine("ProductA!");
        }
    }
}
