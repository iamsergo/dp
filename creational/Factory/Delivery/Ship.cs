using System;

namespace Factory
{
    // Конкретный транспорт
    class Ship : ITransport
    {
        public void Deliver()
        {
            System.Console.WriteLine("Deliver on Ship!");
        }
    }
}
