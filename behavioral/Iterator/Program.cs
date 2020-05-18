using System;

namespace Iterator
{
    class Program
    {
        static void DeveloperApp()
        {
            var app = new DeveloperApplication();
            app.Run();
        }
        static void OddEvenApp()
        {
            var app = new OddEvenApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            // DeveloperApp();
            OddEvenApp();
        }
    }
}
