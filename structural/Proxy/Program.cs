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
        static void Main(string[] args)
        {
            YoutubeApp();
        }
    }
}
