using System;

namespace AbstractFactory
{
    // Интерфейс mac
    class MacGUI : IGUI
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }
        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
