namespace Mediator
{
    // Пользователь - общий интерфейс для составляющих
    abstract class User
    {
        protected IChat chat;
        public string Name { get; set; }
        public User(IChat chat, string name)
        {
            this.chat = chat;
            this.Name = name;
        }
        public void Send(string mes)
        {
            this.chat.Send(mes, this);
        }
        public void Recive(string mes)
        {
            System.Console.WriteLine($"[{this.Name}] recive {mes}");
        }
    }
}