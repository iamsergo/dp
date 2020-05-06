using System;

namespace Factory
{
    // Конкретная кнопка
    class WindowsButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("<BUTTON/>");
        }
    }
}
