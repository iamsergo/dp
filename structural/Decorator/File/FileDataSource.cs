namespace Decorator
{
    // Файловый источник - конкретный компонент
    class FileDataSource : IDataSource
    {
        private string filename;
        private string message;
        public FileDataSource(string filename)
        {
            this.filename = filename;            
        }
        public string Read()
        {
            System.Console.WriteLine("[FileDataSource]");
            System.Console.WriteLine($"Read from [{this.filename}]");
            return $"{this.message}";
        }
        public void Write(string message)
        {
            this.message = message;
        }
    }
}