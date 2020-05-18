namespace Mediator
{
    class Component
    {
        protected IDialogMediator dialog;
        public Component(IDialogMediator dialog)
        {
            this.dialog = dialog;
        }
        public void Click()
        {
            this.dialog.Notify(this, "click");
        }
        public void Keypress()
        {
            this.dialog.Notify(this, "keypress");
        }
    }
}