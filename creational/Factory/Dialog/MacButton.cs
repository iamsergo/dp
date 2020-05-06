using System;

namespace Factory
{
    // Конкретная кнопка
    class MacButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("<button/>");
        }
    }
}
