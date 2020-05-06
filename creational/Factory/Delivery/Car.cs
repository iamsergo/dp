using System;

namespace Factory
{
    // Конкретный транспорт
    class Car : ITransport
    {
        public void Deliver()
        {
            System.Console.WriteLine("Deliver on Car!");
        }
    }
}
