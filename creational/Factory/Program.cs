using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.Run("windows");
        }
    }
}
