using System;

namespace AbstractFactory
{
    class ModernTable : ITable
    {
        public void Put()
        {
            System.Console.WriteLine("Modern table put!");
        }
    }
}
