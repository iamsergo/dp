namespace Observer
{
    class FunctionApplication
    {
        public void Run()
        {
            Button btn = new Button();
            EventType e = new EventType(){ Message = "Hello!", Sender = this};

            btn.OnClick(e => System.Console.WriteLine(e.Message));
            btn.Click(e);
        }
    }
}