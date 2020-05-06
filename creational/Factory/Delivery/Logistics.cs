using System;

namespace Factory
{
    // Фабрика
    abstract class Logistics
    {
        public void Run()
        {
            ITransport tr = this.createTransport();
            tr.Deliver();
        }
        // Фабричный метод
        abstract public ITransport createTransport();
    }
}
