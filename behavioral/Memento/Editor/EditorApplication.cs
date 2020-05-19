namespace Memento
{
    class EditorApplication
    {
        public void Run()
        {
            Editor e = new Editor();
            e.SetCursor(0,4);
            e.SetText("Hello");
            System.Console.WriteLine(e.ToString());

            Command c = new Command(e);
            c.MakeBackup();

            e.SetCursor(2,4);
            e.SetText("Hello !");
            System.Console.WriteLine(e.ToString());

            c.Undo();
            System.Console.WriteLine(e.ToString());
        }
    }
}