using System;

namespace AbstractFactory
{
    // Кнопка mac
    class MacButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("MacButton!");
        }
    }
}
