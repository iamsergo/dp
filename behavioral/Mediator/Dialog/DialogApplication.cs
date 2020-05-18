namespace Mediator
{
    class DialogApplication
    {
        public void Run()
        {
            var dialog = new AuthDialog();
            dialog.Start();
        }
    }
}