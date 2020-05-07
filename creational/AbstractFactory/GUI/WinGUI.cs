using System;

namespace AbstractFactory
{
    // Интерфейс windows
    class WinGUI : IGUI
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }
        public ICheckbox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }
}
