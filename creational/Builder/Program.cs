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
        static void ECarApp()
        {
            EApplication app = new EApplication();
            app.Run();
        }
        static void HomeApplication()
        {
            HomeApp app = new HomeApp();
            app.Run();
        }
        static void Application()
        {
            App app = new App();
            app.Run();
        }
        static void Main(string[] args)
        {
            CarApp();
            ECarApp();
            HomeApplication();
            Application();
        }
    }
}