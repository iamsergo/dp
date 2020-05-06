using System;

namespace Factory
{
    // Конкретный транспорт
    class Truck : ITransport
    {
        public void Deliver()
        {
            System.Console.WriteLine("Deliver on Truck!");
        }
    }
}
