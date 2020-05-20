namespace Observer
{
    class EditorApplication
    {
        public void Run()
        {
            Editor editor = new Editor();

            LoggingListener l = new LoggingListener("log.txt", "Message ->");

            editor.em.Subscribe("open", l);
            editor.OpenFile("1.txt");

            EmailListener e = new EmailListener("123@yandex.ru", "Hello,");

            editor.em.Subscribe("save", e);
            editor.em.Subscribe("save", l);
            editor.SaveFile();

            System.Console.WriteLine("Deleted listener");
            editor.em.Unsubscribe("save", l);
            editor.SaveFile();
        }
    }
}