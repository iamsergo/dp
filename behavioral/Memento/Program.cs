﻿using System;

namespace Memento
{
    class Program
    {
        static void EditorApp()
        {
            var app = new EditorApplication();
            app.Run();
        }
        static void Main(string[] args)
        {
            EditorApp();
        }
    }
}
