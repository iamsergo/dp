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
        static void DatabaseApp()
        {
            var app = new DatabaseApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            ComputerApp();
            DatabaseApp();
        }
    }
}
