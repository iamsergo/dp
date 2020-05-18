namespace Mediator
{
    // Простой пользователь - конкретный пользователь
    class SimpleUser : User
    {
        public SimpleUser(IChat chat, string name) : base(chat, name) {}
    }
}