using System.Collections.Generic;

namespace Mediator
{
    // Текстовый чат - конкретный посредник
    class TextChat : IChat
    {
        private User admin;
        private List<User> users;
        public TextChat()
        {            
            this.users = new List<User>();
        }
        public void SetAdmin(User admin)
        {
            this.admin = admin;
            // this.users.Add(admin);
        }
        public void Add(User user)
        {
            this.users.Add(user);
        }
        public void Send(string mes, User user)
        {
            System.Console.WriteLine($"[{user.Name}] : {mes}");
            foreach (var u in this.users)
            {
                if(u != user)
                {
                    u.Recive(mes);
                }
            }
            this.admin.Recive(mes);
            System.Console.WriteLine("\n");
        }
    }
}