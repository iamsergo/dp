using System;

namespace AbstractFactory
{
    class Modern : IFurniture
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }
        public ITable CreateTable()
        {
            return new ModernTable();
        }
    }
}
