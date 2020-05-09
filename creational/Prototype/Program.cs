using System;

namespace Prototype
{
    class Program
    {
        static void ShapeApp()
        {
            ShapeApplication app = new ShapeApplication();
            app.Run();
        }
        static void MitosApp()
        {
            MitosApplication app = new MitosApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            ShapeApp();
            MitosApp();
        }
    }
}
