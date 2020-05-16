using System;

namespace Command
{
    class Program
    {
        static void ComputerApp()
        {
            var app = new ComputerApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            ComputerApp();
        }
    }
}
