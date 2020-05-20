using System;

namespace Observer
{
    class Program
    {
        static void EditorApp()
        {
            var app = new EditorApplication();
            app.Run();
        }
        static void FunctionApp()
        {
            var app = new FunctionApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            // EditorApp();
            FunctionApp();
        }
    }
}
