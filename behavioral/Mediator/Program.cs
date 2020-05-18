using System;

namespace Mediator
{
    class Program
    {
        static void DialogApp()
        {
            var app = new DialogApplication();
            app.Run();
        }
        static void ChatApp()
        {
            var app = new ChatApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            // DialogApp();
            ChatApp();
        }
    }
}
