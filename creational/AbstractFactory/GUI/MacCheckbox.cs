using System;

namespace AbstractFactory
{
    // Выбор mac
    class MacCheckbox : ICheckbox
    {
        public void Render()
        {
            System.Console.WriteLine("MacCheckbox!");
        }
    }
}
