using System;

namespace Composite
{
    class Program
    {
        static void GraphicApp()
        {
            var app = new GraphicApplication();
            app.Run();
        }
        static void OrderApp()
        {
            var app = new OrderApplication();
            app.Run();
        }
        static void App()
        {
            var app = new Application();
            app.Run();
        }
        static void Main(string[] args)
        {
            GraphicApp();
            OrderApp();
            App();
        }
    }
}
