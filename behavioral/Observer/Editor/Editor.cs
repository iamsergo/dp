namespace Observer
{
    // Редактор - конкретный издатель
    class Editor
    {
        public EventManager em;
        private string file;
        public Editor()
        {
            this.em = new EventManager();
        }

        public void OpenFile(string path)
        {
            System.Console.WriteLine($"{path} is open!");
            this.file = "content";
            this.em.Notify("open", this.file);
        }
        public void SaveFile()
        {
            System.Console.WriteLine("Saved!");
            this.em.Notify("save", this.file);
        }
    }
}