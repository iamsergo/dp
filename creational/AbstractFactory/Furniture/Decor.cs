using System;

namespace AbstractFactory
{
    class Decor : IFurniture
    {
        public IChair CreateChair()
        {
            return new DecorChair();
        }
        public ITable CreateTable()
        {
            return new DecorTable();
        }
    }
}
