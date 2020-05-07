﻿using System;

namespace AbstractFactory
{
    class Program
    {
        static void ConfigureApplication(string t)
        {
            IGUI ui = t switch
            {
                "win" => new WinGUI(),
                "mac" => new MacGUI(),
                _     => null
            };

            Application app = new Application(ui);
            app.CreateUI();
            app.Render();
        }
        static void ConfigureFurniture(string t)
        {
            IFurniture f = t switch
            {
                "modern" => new Modern(),
                "decor"  => new Decor(),
                _        => null
            };

            FurnitureApp app = new FurnitureApp(f);
            app.CreateFurniture();
            app.Put();
        }
        static void Main(string[] args)
        {
            ConfigureApplication("win");
            ConfigureFurniture("modern");
        }
    }
}
