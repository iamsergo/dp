namespace Mediator
{
    // Диалог аунтефикации - конкретный посредник
    class AuthDialog : IDialogMediator
    {
        private string title;
        private Checkbox checkbox;
        private Textbox lu;
        private Textbox lp;
        private Textbox ru;
        private Textbox rp;
        private Textbox re;
        private Button ok;
        private Button cancel;
        public AuthDialog()
        {
            this.checkbox = new Checkbox(this);
            this.lp       = new Textbox(this);
            this.lu       = new Textbox(this);
            this.re       = new Textbox(this);
            this.rp       = new Textbox(this);
            this.ru       = new Textbox(this);
            this.ok       = new Button(this);
            this.cancel   = new Button(this);
        }
        public void Start()
        {
            this.checkbox.Check();
            this.checkbox.Check();

            this.ok.Click();
        }
        private void ShowComponent(Component component)
        {
            System.Console.WriteLine(component.GetType().Name);
        }
        public void Notify(Component sender, string e)
        {
            if(sender == this.checkbox && e == "check")
            {
                if(this.checkbox.Checked)
                {
                    this.title = "login";
                    ShowComponent(this.lu);
                    ShowComponent(this.lp);
                }
                else
                {
                    this.title = "register";
                    ShowComponent(this.ru);
                    ShowComponent(this.rp);
                    ShowComponent(this.re);
                }
                ShowComponent(this.checkbox);
                System.Console.WriteLine($"=[{this.title}]=");
                ShowComponent(this.ok);
                ShowComponent(this.cancel);
                System.Console.WriteLine("\n");
            }

            if(sender == this.ok && e == "click")
            {
                if(this.checkbox.Checked)
                {
                    System.Console.WriteLine("[Authed]");
                }
                else
                {
                    System.Console.WriteLine("[Registered]");
                }
            }
        }
    }
}