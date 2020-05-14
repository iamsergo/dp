using System;

namespace Proxy
{
    class Program
    {
        static void YoutubeApp()
        {
            var app = new YoutubeApplication();
            app.Run();
        }
        static void DoorApp()
        {
            var app = new DoorApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            // Кэширование
            YoutubeApp();

            // Защита
            DoorApp();

        }
    }
}
