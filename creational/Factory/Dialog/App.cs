using System;

namespace Factory
{
    class App
    {
        private Dialog d;
        public void Run(string type)
        {
            this.d = type switch {
                "windows" => new Windows(),
                "mac"     => new Mac(),
                _ => null
            };

            this.d.Render();
            
            // ((Dialog)(type switch
            // {
            //     "windows" => new Windows(),
            //     "mac" => new Mac(),
            //     _ => null
            // })).Render();
        }
    }
}
