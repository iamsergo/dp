﻿using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.Run("windows");

            LogisticApp a = new LogisticApp("car");
            a.Run();

            Application an = new Application("b");
            an.Run();
        }
    }
}
