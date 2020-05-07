using System;

namespace AbstractFactory
{
    // Общий интефейс gui
    interface IGUI
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
