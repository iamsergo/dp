namespace Mediator
{
    // Администратор - конкретный пользоваетль
    class AdminUser : User
    {
        public AdminUser(IChat chat, string name) : base(chat, name) {}
    }
}