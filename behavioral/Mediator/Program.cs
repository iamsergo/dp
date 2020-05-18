using System;

namespace Mediator
{
    class Program
    {
        static void DialogApp()
        {
            var app = new DialogApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            DialogApp();
        }
    }
}
