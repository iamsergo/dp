namespace Mediator
{
    class ChatApplication
    {
        public void Run()
        {
            var chat = new TextChat();

            AdminUser  a  = new AdminUser(chat, "Admin");
            SimpleUser u1 = new SimpleUser(chat, "User1");
            SimpleUser u2 = new SimpleUser(chat, "User2");

            chat.SetAdmin(a);

            chat.Add(u1);
            chat.Add(u2);

            a.Send("Welcome to the chat!");
            u1.Send("Hello!");
        }
    }
}