using System;

namespace Factory
{
    // Конкретный продукт
    class ConcreteProductB : IProduct
    {
        public void Method()
        {
            System.Console.WriteLine("Product B!");
        }
    }
}
