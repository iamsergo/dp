using System;

namespace Decorator
{
    class Program
    {
        static void FileApp()
        {
            var app = new FileApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            FileApp();
        }
    }
}