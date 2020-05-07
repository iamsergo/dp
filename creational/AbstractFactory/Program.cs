using System;

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
        static void Main(string[] args)
        {
            ConfigureApplication("win");
        }
    }
}
