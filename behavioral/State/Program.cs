using System;

namespace State
{
    class Program
    {
        static void PlayerApp()
        {
            var app = new PlayerApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            PlayerApp();
        }
    }
}
