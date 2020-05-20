namespace Observer
{
    // Электронная почта - конкретный подписчик
    class EmailListener : IEditorListener
    {
        private string email;
        private string mes;
        public EmailListener(string email, string mes)
        {
            this.email = email;
            this.mes = mes;
        }

        public void Update(string data)
        {
            System.Console.WriteLine($"[{this.email}]:\n{mes}\n{data}\n");
        }
    }
}