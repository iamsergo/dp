namespace Mediator
{
    class Checkbox : Component
    {
        public bool Checked;
        public Checkbox(IDialogMediator dialog) : base(dialog) {}
        public void Check()
        {
            this.Checked = !this.Checked;
            this.dialog.Notify(this, "check");
        }
    }
}