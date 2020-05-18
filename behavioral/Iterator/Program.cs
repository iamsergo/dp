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
        static void SequenceApp()
        {
            var app = new SequenceApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            //DeveloperApp();
            // OddEvenApp();
            SequenceApp();
        }
    }
}
