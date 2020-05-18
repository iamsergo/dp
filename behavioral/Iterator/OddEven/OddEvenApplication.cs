using System.Collections.Generic;

namespace Iterator
{
    class OddEvenApplication
    {
        public void Run()
        {
            ISequence seq = new Sequence(
                new List<int>(){ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
            );

            var ie = seq.CreateEvenIterator();
            var io = seq.CreateOddIterator();

            System.Console.WriteLine("[Even]:");
            while (ie.CanMove())
            {
                System.Console.WriteLine(ie.Next());
            }

            System.Console.WriteLine("\n[Odd]:");
            while (io.CanMove())
            {
                System.Console.WriteLine(io.Next());
            }
        }
    }
}