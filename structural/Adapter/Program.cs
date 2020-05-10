using System;

namespace Adapter
{
    class Program
    {
        static void HoleAndPegApp()
        {
            var app = new HoleAndPegApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            HoleAndPegApp();
        }
    }
}