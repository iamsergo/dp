using System;

namespace AbstractFactory
{
    class DecorTable : ITable
    {
        public void Put()
        {
            System.Console.WriteLine("Decor table put!");
        }
    }
}
