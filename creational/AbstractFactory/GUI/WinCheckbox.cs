using System;

namespace AbstractFactory
{
    // Выбор windows
    class WinCheckbox : ICheckbox
    {
        public void Render()
        {
            System.Console.WriteLine("WinCheckbox!");
        }
    }
}
