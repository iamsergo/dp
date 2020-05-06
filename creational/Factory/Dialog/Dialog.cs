using System;

namespace Factory
{
    // Общая фабрика
    abstract class Dialog
    {
        public void Render()
        {
            IButton btn = this.CreateButton();
            btn.Render();
        }
        // Фабричный метод
        abstract public IButton CreateButton();
    }
}
