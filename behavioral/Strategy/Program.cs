using System;

namespace Strategy
{
    class Program
    {
        static void CalculatorApp()
        {
            var app = new CalculatorApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            CalculatorApp();
        }
    }
}
