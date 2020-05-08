using System;

namespace Builder
{
    class Program
    {
        static void CarApp()
        {
            Application app = new Application();
            app.Run();
        }
        static void Main(string[] args)
        {
            CarApp();
        }
    }
}