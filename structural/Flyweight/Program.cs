using System;

namespace Flyweight
{
    class Program
    {
        static void ShapeApp()
        {
            var app = new ShapeApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            ShapeApp();
        }
    }
}
