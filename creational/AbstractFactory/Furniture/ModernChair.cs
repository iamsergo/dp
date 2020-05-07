using System;

namespace AbstractFactory
{
    class ModernChair : IChair
    {
        public void Put()
        {
            System.Console.WriteLine("Modern chair put!");
        }
    }
}
