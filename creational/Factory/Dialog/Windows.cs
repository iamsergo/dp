using System;

namespace Factory
{
    // Конкретная фабрика
    class Windows : Dialog
    {
        // Фабричный метод
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
