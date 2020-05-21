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
        static void LightApp()
        {
            var app = new LightApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            // PlayerApp();
            LightApp();
        }
    }
}
