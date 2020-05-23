using System;

namespace TemplateMethod
{
    class Program
    {
        static void WebSiteApp()
        {
            var app = new WebSiteApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            WebSiteApp();
        }
    }
}
