using System;

namespace Bridge
{
    class Program
    {
        static void DevicesApp()
        {
            var app = new DevicesApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            DevicesApp();
        }
    }
}
