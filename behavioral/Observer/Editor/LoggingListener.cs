namespace Observer
{
    // Логгер - конкретный подписчик
    class LoggingListener : IEditorListener
    {
        private string log;
        private string mes;
        public LoggingListener(string log, string mes)
        {
            this.log = log;
            this.mes = mes;
        }
        public void Update(string data)
        {
            System.Console.WriteLine($"[{this.log}]:\n{this.mes}\n{data}\n");
        }
    }
}