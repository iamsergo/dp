using System;

namespace AbstractFactory
{
    // Кнопка windows
    class WinButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("WinButton!");
        }
    }
}
