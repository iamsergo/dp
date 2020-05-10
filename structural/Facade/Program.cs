using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoFacade vf = new VideoFacade();
            vf.Convert();
        }
    }
}