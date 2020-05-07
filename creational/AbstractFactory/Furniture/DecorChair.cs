using System;

namespace AbstractFactory
{
    class DecorChair : IChair
    {
        public void Put()
        {
            System.Console.WriteLine("Decor chair put!");
        }
    }
}
