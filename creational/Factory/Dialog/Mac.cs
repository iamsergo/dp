using System;

namespace Factory
{
    // Конкретная фабрика
    class Mac : Dialog
    {
        // Фабричный метод
        public override IButton CreateButton()
        {
            return new MacButton();
        }
    }
}
