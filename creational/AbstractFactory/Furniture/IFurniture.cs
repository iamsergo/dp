using System;

namespace AbstractFactory
{
    interface IFurniture
    {
        IChair CreateChair();
        ITable CreateTable();
    }
}
