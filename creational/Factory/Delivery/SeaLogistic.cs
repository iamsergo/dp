using System;

namespace Factory
{
    // Фабрика морских перевозчиков
    class SeaLogistics : Logistics
    {
        override public ITransport createTransport()
        {
            return new Ship();
        }
    }
}
