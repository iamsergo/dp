using System;

namespace AbstractFactory
{
    class Application
    {
        private IGUI ui;
        private IButton btn;
        private ICheckbox ch;
        public Application(IGUI ui)
        {
            this.ui = ui;
        }
        public void CreateUI()
        {
            this.btn = ui.CreateButton();
            this.ch  = ui.CreateCheckbox();
        }
        public void Render()
        {
            this.btn.Render();
            this.ch.Render();
        }
    }
}
