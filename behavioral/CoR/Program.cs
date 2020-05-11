using System;

namespace CoR
{
    class Program
    {
        static void ResponseApp()
        {
            var app = new ResponseApplication();
            app.Run();
        }
        static void LoginApp()
        {
            var app = new LoginApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            //ResponseApp();
            LoginApp();
        }
    }
}
